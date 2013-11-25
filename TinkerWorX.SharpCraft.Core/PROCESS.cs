using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Core
{
    [Flags]
    public enum PROCESS : uint
    {
        /// <summary>
        /// Required to terminate a process using TerminateProcess.
        /// </summary>
        TERMINATE = 0x0001,
        /// <summary>
        /// Required to create a thread.
        /// </summary>
        CREATE_THREAD = 0x0002,
        /// <summary>
        /// N/A
        /// </summary>
        SET_SESSION_ID = 0x0004,
        /// <summary>
        /// Required to perform an operation on the address space of a process (see VirtualProtectEx and WriteProcessMemory).
        /// </summary>
        VM_OPERATION = 0x0008,
        /// <summary>
        /// Required to read memory in a process using ReadProcessMemory.
        /// </summary>
        VM_READ = 0x0010,
        /// <summary>
        /// Required to write to memory in a process using WriteProcessMemory.
        /// </summary>
        VM_WRITE = 0x0020,
        /// <summary>
        /// Required to duplicate a handle using DuplicateHandle.
        /// </summary>
        DUP_HANDLE = 0x0040,
        /// <summary>
        /// Required to create a process.
        /// </summary>
        CREATE_PROCESS = 0x0080,
        /// <summary>
        /// Required to set memory limits using SetProcessWorkingSetSize.
        /// </summary>
        SET_QUOTA = 0x0100,
        /// <summary>
        /// Required to set certain information about a process, such as its priority class (see SetPriorityClass).
        /// </summary>
        SET_INFORMATION = 0x0200,
        /// <summary>
        /// Required to retrieve certain information about a process, such as its token, exit code, and priority class (see OpenProcessToken, GetExitCodeProcess, GetPriorityClass, and IsProcessInJob).
        /// </summary>
        QUERY_INFORMATION = 0x0400,
        /// <summary>
        /// Required to suspend or resume a process.
        /// </summary>
        SUSPEND_RESUME = 0x0800,
        /// <summary>
        /// Required to retrieve certain information about a process (see QueryFullProcessImageName). A handle that has the QueryInformation access right is automatically granted QueryLimitedInformation.
        /// </summary>
        QUERY_LIMITED_INFORMATION = 0x1000,
        /// <summary>
        /// All possible access rights for a process object.
        /// </summary>
        ALL_ACCESS = (UInt32)(ACCESS_TYPE.STANDARD_RIGHTS_REQUIRED | ACCESS_TYPE.SYNCHRONIZE | 0xFFFF),
    }
}
