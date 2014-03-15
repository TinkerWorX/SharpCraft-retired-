using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    /// <summary>
    /// Jass String
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JassString
    {
        public IntPtr VTable;
        public IntPtr Field_0004;
        public RCString* Value;
        public IntPtr Field_000C;

        public override String ToString()
        {
            return this.Value->ToString();
        }
    }
}
