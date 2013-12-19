using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game.Core
{
    [StructLayout(LayoutKind.Sequential, Size = 0xC)]
    unsafe public struct SymbolTable
    {
        public IntPtr FirstOperation;
        public Int32 ProgramLength;
        public StringPool* StringPool;
    }
}
