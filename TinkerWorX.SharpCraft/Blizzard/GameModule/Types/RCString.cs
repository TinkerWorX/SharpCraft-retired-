using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    /// <summary>
    /// Reference Counted String
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RCString
    {
        public IntPtr VTable;
        public IntPtr Field_0004;
        public IntPtr Field_0008;
        public IntPtr Field_000C;
        public IntPtr Field_0010;
        public IntPtr Field_0014;
        public IntPtr Field_0018;
        public IntPtr Value;

        public override String ToString()
        {
            return Memory.ReadString(this.Value);
        }
    }
}
