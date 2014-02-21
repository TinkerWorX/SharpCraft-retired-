using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft
{
    public abstract class FullPluginBase : MarshalByRefObject
    {
        internal void InternalInitialize()
        {
            Input.Initialize();
            Interface.Initialize();
            Natives.Initialize();
            Script.Initialize();
        }

        public virtual void Initialize() { }

        public virtual void OnGameReady() { }

        public virtual void CheatCallback(String cheat) { }

        public virtual void CreateUnitCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void CreateCorpseCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void RemoveUnitCallback(JassUnit unit) { }
    }
}
