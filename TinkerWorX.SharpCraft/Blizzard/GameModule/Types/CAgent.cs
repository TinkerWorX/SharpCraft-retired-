using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential/*, Size = unknown*/)]
    unsafe public struct CAgent : IAgent<CAgentPtr>
    {
        public CAgentVTable* Virtual;

        public CAgentPtr AsSafe()
        {
            fixed (CAgent* pointer = &this)
                return new CAgentPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }

        public CAgent* ToBase()
        {
            fixed (CAgent* @this = &this)
                return @this;
        }

        public ObjectIdL GetClassId()
        {
            return this.Virtual->GetClassId(this.AsSafe());
        }

        public String GetClassName()
        {
            return this.Virtual->GetClassNameString(this.AsSafe());
        }
    }

    public struct CAgentPtr
    {
        private IntPtr pointer;

        unsafe public CAgentPtr(CAgent* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CAgentPtr(void* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CAgentPtr(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        unsafe public CAgent* AsUnsafe()
        {
            return (CAgent*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }

    unsafe public struct CAgentVTable
    {
        public IntPtr Func01;
        public IntPtr Func02;
        public IntPtr Func03;
        public IntPtr Func04;
        public IntPtr Func05;
        public IntPtr Func06;
        public IntPtr Func07;
        public IntPtr CAgent__GetClassId;
        public IntPtr Func09;
        public IntPtr Func10;
        public IntPtr Func11;
        public IntPtr Func12;
        public IntPtr Func13;
        public IntPtr Func14;
        public IntPtr Func15;
        public IntPtr Func16;
        public IntPtr Func17;
        public IntPtr Func18;
        public IntPtr Func19;
        public IntPtr Func20;
        public IntPtr Func21;
        public IntPtr Func22;
        public IntPtr CAgent__GetClassName;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate ObjectIdL GetClassHashPrototype(CAgentPtr @this);
        public GetClassHashPrototype GetClassId { get { return Utility.PtrAsFunction<GetClassHashPrototype>(this.CAgent__GetClassId); } }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr GetClassNamePrototype(CAgentPtr @this);
        public GetClassNamePrototype GetClassName { get { return Utility.PtrAsFunction<GetClassNamePrototype>(this.CAgent__GetClassName); } }
        public String GetClassNameString(CAgentPtr @this)
        {
            return Marshal.PtrToStringAnsi(this.GetClassName(@this));
        }
    }
}
