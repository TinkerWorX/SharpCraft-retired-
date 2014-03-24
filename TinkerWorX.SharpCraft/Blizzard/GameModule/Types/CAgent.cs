using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Utilities.UnmanagedCalls;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential, Size = 0x04)]
    public struct CAgent : IAgent<CAgentInternal>
    {
        unsafe public static CAgent FromPointer(CAgentInternal* pointer)
        {
            return new CAgent(new IntPtr(pointer));
        }

        unsafe public static CAgent FromPointer(void* pointer)
        {
            return new CAgent(new IntPtr(pointer));
        }

        unsafe public static CAgent FromPointer(IntPtr pointer)
        {
            return new CAgent(pointer);
        }



        private readonly IntPtr pointer;

        private CAgent(IntPtr pointer)
        {
            this.pointer = pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }

        unsafe public CAgentInternal* AsUnsafe()
        {
            return (CAgentInternal*)this.pointer;
        }

        public CAgent ToBase()
        {
            return this;
        }
    }

    [StructLayout(LayoutKind.Sequential/*, Size = variable*/)]
    unsafe public struct CAgentInternal : IAgentInternal<CAgent>
    {
        public VTable* Virtual;

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }

        public CAgent AsSafe()
        {
            fixed (CAgentInternal* pointer = &this)
                return CAgent.FromPointer(pointer);
        }

        public CAgentInternal* ToBase()
        {
            fixed (CAgentInternal* @this = &this)
                return @this;
        }

        public ObjectIdL GetClassId()
        {
            return ThisCall.Invoke<ObjectIdL>(this.Virtual->CAgent__GetClassId, this.AsSafe());
        }

        public ObjectIdL ClassId
        {
            get { return this.GetClassId(); }
        }

        public String GetClassName()
        {
            return Memory.ReadString(ThisCall.Invoke<IntPtr>(this.Virtual->CAgent__GetClassName, this.AsSafe()));
        }

        public String ClassName
        {
            get { return this.GetClassName(); }
        }

        public struct VTable
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
        }
    }
}
