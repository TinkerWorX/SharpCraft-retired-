using System;
using System.IO;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential/*, Size = unknown*/)]
    unsafe public struct AbilityLevelData
    {
        public IntPtr field0000;
        public Single CastingTime;
        public Single DurationNormal;
        public Single DurationHero;

        public Int32 ManaCost;
        public Single Cooldown;
        public Single AreaOfEffect;
        public Single CastRange;

        public IntPtr DataA;
        public IntPtr DataB;
        public IntPtr DataC;
        public IntPtr DataD;

        public IntPtr DataE;
        public IntPtr DataF;
        public IntPtr DataG;
        public IntPtr DataH;

        public IntPtr DataI;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;

        public IntPtr field0050;
        public ObjectIdL BuffId;
        public IntPtr field0058;
        public IntPtr field005C;

        public IntPtr field0060;
        public IntPtr field0064;

        public AbilityLevelDataPtr AsSafe()
        {
            fixed (AbilityLevelData* pointer = &this)
                return new AbilityLevelDataPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }

        public void SetDataA<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataA = &this.DataA)
                Memory.Write<T>(new IntPtr(dataA), data);
        }

        public T GetDataA<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataA = &this.DataA)
                return Memory.Read<T>(new IntPtr(dataA));
        }

        public void SetDataB<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataB = &this.DataB)
                Memory.Write<T>(new IntPtr(dataB), data);
        }

        public T GetDataB<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataB = &this.DataB)
                return Memory.Read<T>(new IntPtr(dataB));
        }

        public void SetDataC<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataC = &this.DataC)
                Memory.Write<T>(new IntPtr(dataC), data);
        }

        public T GetDataC<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataC = &this.DataC)
                return Memory.Read<T>(new IntPtr(dataC));
        }

        public void SetDataD<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataD = &this.DataD)
                Memory.Write<T>(new IntPtr(dataD), data);
        }

        public T GetDataD<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataD = &this.DataD)
                return Memory.Read<T>(new IntPtr(dataD));
        }

        public void SetDataE<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataE = &this.DataE)
                Memory.Write<T>(new IntPtr(dataE), data);
        }

        public T GetDataE<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataE = &this.DataE)
                return Memory.Read<T>(new IntPtr(dataE));
        }

        public void SetDataF<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataF = &this.DataF)
                Memory.Write<T>(new IntPtr(dataF), data);
        }

        public T GetDataF<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataF = &this.DataF)
                return Memory.Read<T>(new IntPtr(dataF));
        }

        public void SetDataG<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataG = &this.DataG)
                Memory.Write<T>(new IntPtr(dataG), data);
        }

        public T GetDataG<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataG = &this.DataG)
                return Memory.Read<T>(new IntPtr(dataG));
        }

        public void SetDataH<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataH = &this.DataH)
                Memory.Write<T>(new IntPtr(dataH), data);
        }

        public T GetDataH<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataH = &this.DataH)
                return Memory.Read<T>(new IntPtr(dataH));
        }

        public void SetDataI<T>(T data) where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataI = &this.DataI)
                Memory.Write<T>(new IntPtr(dataI), data);
        }

        public T GetDataI<T>() where T : struct
        {
            if (typeof(T) == typeof(String))
                throw new ArgumentException("T cannot be String", "<T>");
            fixed (void* dataI = &this.DataI)
                return Memory.Read<T>(new IntPtr(dataI));
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AbilityLevelDataPtr
    {
        private IntPtr pointer;

        unsafe public AbilityLevelDataPtr(AbilityLevelData* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public AbilityLevelData* AsUnsafe()
        {
            return (AbilityLevelData*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
