using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    public abstract class ManagedActionBase : MarshalByRefObject
    {
        public virtual Boolean Condition(JassTrigger trigger) { return true; }
        public virtual void Action(JassTrigger trigger) { }

        public void Invoke(JassTrigger trigger)
        {
            if (this.Condition(trigger))
                this.Action(trigger);
        }
    }
}
