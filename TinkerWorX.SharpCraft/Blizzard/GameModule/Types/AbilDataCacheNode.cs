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
    unsafe public struct AbilDataCacheNode
    {
        public static AbilDataCacheNode* FromId(ObjectIdL id)
        {
            return GameFunctions.GetAbilDataCacheNodeFromId(id).AsUnsafe();
        }



        public IntPtr field0000;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;

        public IntPtr field0010;
        public ObjectIdL AbilityId_0;
        public ObjectIdL AbilityId_1;
        public IntPtr field001C;

        public IntPtr field0020;
        public IntPtr field0024;
        public IntPtr field0028;
        public IntPtr field002C;

        public ObjectIdL BaseAbilityId;
        public ObjectIdL AbilityId;
        public IntPtr field0038;
        public IntPtr field003C;

        public IntPtr field0040;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;

        public Int32 Levels;
        public AbilityLevelData* Level;

        public AbilDataCacheNodePtr AsSafe()
        {
            fixed (AbilDataCacheNode* @this = &this)
                return new AbilDataCacheNodePtr(@this);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* @this = &this)
                return new IntPtr(@this);
        }

        public AbilDataCacheNode* Clone()
        {
            fixed (void* @this = &this)
            {
                // We allocate new memory using SMemAlloc. This way WC3 knows how to clean it.
                var clone = (AbilDataCacheNode*)Storm.MemoryAlloc(sizeof(AbilDataCacheNode));

                // We copy the old data into our newly allocated memory.
                Memory.Copy(new IntPtr(@this), new IntPtr(clone), sizeof(AbilDataCacheNode));

                // We also clone the AbilityLevelData array.
                var levelData = (AbilityLevelData*)Storm.MemoryAlloc(sizeof(AbilityLevelData) * this.Levels);
                Memory.Copy(new IntPtr(this.Level), new IntPtr(levelData), sizeof(AbilityLevelData) * this.Levels);
                clone->Level = levelData;

                return clone;
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AbilDataCacheNodePtr
    {
        public static AbilDataCacheNodePtr FromId(ObjectIdL id)
        {
            return GameFunctions.GetAbilDataCacheNodeFromId(id);
        }



        private IntPtr pointer;

        unsafe public AbilDataCacheNodePtr(AbilDataCacheNode* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public AbilDataCacheNode* AsUnsafe()
        {
            return (AbilDataCacheNode*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }
}
