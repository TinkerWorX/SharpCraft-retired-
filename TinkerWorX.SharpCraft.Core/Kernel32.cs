using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Core
{
    public static class Kernel32
    {
        public delegate IntPtr LoadLibraryPrototype(String fileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibrary(String fileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibraryA(String fileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibraryW(String fileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(String moduleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandleA(String moduleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandleW(String moduleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAlloc(IntPtr address, Int32 size, AllocationType allocationType, MemoryProtection protection);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Boolean VirtualFree(IntPtr address, Int32 size, MemoryFreeType freeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FreeConsole();

        [DllImport("kernel32", SetLastError = true)]
        public static extern bool AttachConsole(Int32 processId);

        /// <summary>
        /// Open a process
        /// </summary>
        /// <param name="dwDesiredAccess">Access flag</param>
        /// <param name="bInheritHandle">Handle inheritance options</param>
        /// <param name="dwProcessId">Process identifier</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(PROCESS dwDesiredAccess, Int32 bInheritHandle, IntPtr dwProcessId);

        /// <summary>
        /// Terminate a (open) process
        /// </summary>
        /// <param name="dwProcessId">Handle</param>
        /// <param name="dwExitCode">Exit code</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 TerminateProcess(IntPtr dwProcessId, UInt32 dwExitCode);

        /// <summary>
        /// Close a handle
        /// </summary>
        /// <param name="hObject">Handle to object</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hObject);

        /// <summary>
        /// Write to the memory of a process    
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to write</param>
        /// <param name="lpNumberOfBytesWritten">Number of bytes written</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 WriteProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size, ref IntPtr lpNumberOfBytesWritten);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern Int32 WriteProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size, Int32 AlwaysZero);
        /// <summary>
        /// Write to the memory of a process    
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to write</param>
        /// <param name="lpNumberOfBytesWritten">Number of bytes written</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 WriteProcessMemory(IntPtr process, UInt32 baseAddress, IntPtr buffer, Int32 size, ref IntPtr lpNumberOfBytesWritten);
        /// <summary>
        /// Write to the memory of a process    
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to write</param>
        /// <returns>Success</returns>
        public static Int32 WriteProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size)
        {
            return WriteProcessMemory(process, baseAddress, buffer, size, 0);
        }
        /// <summary>
        /// Write to the memory of a process    
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to write</param>
        /// <returns>Success</returns>
        public static Int32 WriteProcessMemory(IntPtr process, UInt32 baseAddress, IntPtr buffer, Int32 size)
        {
            return WriteProcessMemory(process, (IntPtr)baseAddress, buffer, size);
        }

        /// <summary>
        /// Read from the memory of a process 
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to read</param>
        /// <param name="lpNumberOfBytesRead">Number of bytes read</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 ReadProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size, ref IntPtr lpNumberOfBytesRead);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern Int32 ReadProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size, Int32 AlwaysZero);
        /// <summary>
        /// Read from the memory of a process 
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to read</param>
        /// <param name="lpNumberOfBytesRead">Number of bytes read</param>
        /// <returns>Success</returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern Int32 ReadProcessMemory(IntPtr process, UInt32 baseAddress, IntPtr buffer, Int32 size, ref IntPtr lpNumberOfBytesRead);
        /// <summary>
        /// Read from the memory of a process 
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to read</param>
        /// <returns>Success</returns>
        public static Int32 ReadProcessMemory(IntPtr process, IntPtr baseAddress, IntPtr buffer, Int32 size)
        {
            return ReadProcessMemory(process, baseAddress, buffer, size, 0);
        }
        /// <summary>
        /// Read from the memory of a process 
        /// </summary>
        /// <param name="process">Handle to the process</param>
        /// <param name="baseAddress">Base of memory area</param>
        /// <param name="buffer">Data buffer</param>
        /// <param name="size">Number of bytes to read</param>
        /// <returns>Success</returns>
        public static Int32 ReadProcessMemory(IntPtr process, UInt32 baseAddress, IntPtr buffer, Int32 size)
        {
            return ReadProcessMemory(process, (IntPtr)baseAddress, buffer, size);
        }
    }

    [Flags]
    public enum AllocationType : uint
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Reset = 0x80000,
        LargePages = 0x20000000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000
    }

    [Flags]
    public enum MemoryProtection : uint
    {
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,
        GuardModifierflag = 0x100,
        NocacheModifierflag = 0x200,
        WriteCombineModifierflag = 0x400
    }

    [Flags]
    public enum MemoryFreeType : uint
    {
        Decommit = 0x4000,
        Release = 0x8000
    }
}
