using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.SharpCraft.Utilities;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    [StructLayout(LayoutKind.Sequential/*, Size = unknown*/)]
    unsafe public struct CAbility : IAgentInternal<CAbilityPtr>
    {
        private static Dictionary<IntPtr, Boolean> isCAbilityDataUnique = new Dictionary<IntPtr, Boolean>();



        public CAbilityVTable* Virtual;
        public IntPtr field0004;
        public IntPtr field0008;
        public IntPtr field000C;

        public IntPtr field0010;
        public IntPtr field0014;
        public IntPtr field0018;
        public IntPtr field001C;

        public IntPtr field0020;
        public IntPtr field0024;
        public IntPtr field0028;
        public IntPtr field002C;

        public CUnitInternal* Owner; // - The unit that has the ability.
        public ObjectIdL AbilityId; // - The ability id.
        public IntPtr field0038;
        public IntPtr field003C;

        public IntPtr field0040;
        public IntPtr field0044;
        public IntPtr field0048;
        public IntPtr field004C;

        public IntPtr field0050;
        public AbilDataCacheNode* Data; // - The ability data cache.
        public IntPtr field0058;
        public IntPtr field005C;

        public CAbilityPtr AsSafe()
        {
            fixed (CAbility* pointer = &this)
                return new CAbilityPtr(pointer);
        }

        public IntPtr AsIntPtr()
        {
            fixed (void* pointer = &this)
                return new IntPtr(pointer);
        }

        public CAgentInternal* ToBase()
        {
            fixed (void* pointer = &this)
                return (CAgentInternal*)pointer;
        }

        public ObjectIdL GetClassId()
        {
            return this.ToBase()->GetClassId();
        }

        public String GetClassName()
        {
            return this.ToBase()->GetClassName();
        }

        public Boolean MakeDataUnique()
        {
            var isDataUnique = false;
            isCAbilityDataUnique.TryGetValue(this.AsIntPtr(), out isDataUnique);
            if (isDataUnique)
                return false;
            // Clone and use new data from the cache.
            this.Data = AbilDataCacheNode.FromId(this.AbilityId)->Clone();
            isCAbilityDataUnique[this.AsIntPtr()] = true;
            return true;
        }

        public Boolean MakeDataShared()
        {
            var isUnique = false;
            isCAbilityDataUnique.TryGetValue(this.AsIntPtr(), out isUnique);
            if (!isUnique)
                return false;
            // Free the old unique data, to avoid leaking.
            Storm.MemoryFree(new IntPtr(this.Data));
            // Use old data from the cache.
            this.Data = AbilDataCacheNode.FromId(this.AbilityId);
            isCAbilityDataUnique[this.AsIntPtr()] = false;
            return true;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CAbilityPtr
    {
        private IntPtr pointer;

        unsafe public CAbilityPtr(CAbility* pointer)
        {
            this.pointer = new IntPtr(pointer);
        }

        unsafe public CAbility* AsUnsafe()
        {
            return (CAbility*)this.pointer;
        }

        public IntPtr AsIntPtr()
        {
            return this.pointer;
        }
    }

    unsafe public struct CAbilityVTable
    {
        public IntPtr* Function;
    }
}
