using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x7C)]
    unsafe public struct CTriggerWar3
    {
        public static CTriggerWar3* FromHandle(IntPtr triggerHandle)
        {
            return GameFunctions.GetTriggerFromHandle(triggerHandle).AsUnsafe();
        }

        public CTriggerWar3VTable* Virtual;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;
        public IntPtr field0010;
        public IntPtr field0014;
        public IntPtr field0018;
        public IntPtr field001C;
        public IntPtr field0020;
        public IntPtr field0024;
        public IntPtr field0028;
        public IntPtr field002C;
        public IntPtr field0030;
        public IntPtr field0034;
        public IntPtr field0038;
        public IntPtr field003C;
        public IntPtr field0040;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;
        public IntPtr field0050;
        public IntPtr field0054;
        public IntPtr field0058;
        public IntPtr field005C;
        public IntPtr field0060;
        public IntPtr field0064;
        public IntPtr field0068;
        public IntPtr field006C;
        public IntPtr field0070;
        public IntPtr field0074;
        public IntPtr field0078;

        public CTriggerWar3Ptr AsSafe()
        {
            fixed (CTriggerWar3* pointer = &this)
                return new CTriggerWar3Ptr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    public struct CTriggerWar3Ptr
    {
        public static CTriggerWar3Ptr FromHandle(IntPtr triggerHandle)
        {
            return GameFunctions.GetTriggerFromHandle(triggerHandle);
        }



        private IntPtr pointer;

        unsafe public CTriggerWar3Ptr(CTriggerWar3* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CTriggerWar3* AsUnsafe()
        {
            return (CTriggerWar3*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }

    unsafe public struct CTriggerWar3VTable
    {
        public IntPtr* Function;
    }
}
