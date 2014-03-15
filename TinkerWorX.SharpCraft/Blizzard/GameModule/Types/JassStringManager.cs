using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    /// <summary>
    /// Holds all the Jass Strings that has been made.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JassStringManager
    {
        public IntPtr Field_0000;
        public IntPtr Field_0004;
        public JassString* Strings;
    }
}
