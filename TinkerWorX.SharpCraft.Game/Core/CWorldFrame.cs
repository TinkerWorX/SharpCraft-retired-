using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CWorldFrame
    {
        private readonly IntPtr ptr;

        public void WriteLine(String message, CColor color, Single duration)
        {
            WarcraftIII.Interface.CWorldFrame__WriteLine(this, message, ref color, duration, 0);
        }
    }
}
