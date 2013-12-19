using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0xC)]
    unsafe public struct StringPool
    {
        public IntPtr field0000;
        public IntPtr field0004;
        public StringNode** Nodes;
    }
}
