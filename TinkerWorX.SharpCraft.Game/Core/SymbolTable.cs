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

        public SymbolTablePtr AsSafe()
        {
            fixed (SymbolTable* pointer = &this)
                return new SymbolTablePtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SymbolTablePtr
    {
        private IntPtr pointer;

        unsafe public SymbolTablePtr(SymbolTable* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public SymbolTable* AsUnsafe()
        {
            return (SymbolTable*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
