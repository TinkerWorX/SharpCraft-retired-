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
            //sub_6F6049B0(this.ptr, message, ref color, duration, 0);
        }
    }
}
