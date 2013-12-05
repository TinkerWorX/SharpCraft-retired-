using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Core
{
    public class ProcessMemory
    {
        public static ProcessMemory FromProcess(Process process)
        {
            return new ProcessMemory(process);
        }

        private IntPtr buffer { get; set; }

        public Process Process { get; private set; }

        public IntPtr ProcessHandle { get; private set; }

        private ProcessMemory(Process process)
        {
            this.Process = process;

            this.ProcessHandle = Kernel32.OpenProcess(PROCESS.ALL_ACCESS, 0, (IntPtr)this.Process.Id);
            if (ProcessHandle == IntPtr.Zero)
            {
                IntPtr pDACL, pSecDesc;

                AdvancedServices.GetSecurityInfo(Process.GetCurrentProcess().Handle, /*SE_KERNEL_OBJECT*/ 6, /*DACL_SECURITY_INFORMATION*/ 4, 0, 0, out pDACL, IntPtr.Zero, out pSecDesc);
                this.ProcessHandle = Kernel32.OpenProcess(/*WRITE_DAC*/ (PROCESS)0x40000, 0, (IntPtr)this.Process.Id);
                AdvancedServices.SetSecurityInfo(this.ProcessHandle, /*SE_KERNEL_OBJECT*/ 6, /*DACL_SECURITY_INFORMATION*/ 4 | /*UNPROTECTED_DACL_SECURITY_INFORMATION*/ 0x20000000, 0, 0, pDACL, IntPtr.Zero);
                Kernel32.CloseHandle(this.ProcessHandle);

                this.ProcessHandle = Kernel32.OpenProcess(PROCESS.ALL_ACCESS, 0, (IntPtr)this.Process.Id);
            }
            if (this.ProcessHandle == IntPtr.Zero)
                throw new InvalidOperationException("Failed to open up process");

            this.buffer = Marshal.AllocHGlobal(8192);
        }

        public T Read<T>(IntPtr address) where T : struct
        {
            Kernel32.ReadProcessMemory(this.ProcessHandle, address, this.buffer, Marshal.SizeOf(typeof(T)));
            return (T)Marshal.PtrToStructure(this.buffer, typeof(T));
        }

        public void Write<T>(IntPtr address, T data) where T : struct
        {
            Marshal.StructureToPtr(data, this.buffer, true);
            Kernel32.WriteProcessMemory(this.ProcessHandle, address, this.buffer, Marshal.SizeOf(typeof(T)));
        }
    }
}
