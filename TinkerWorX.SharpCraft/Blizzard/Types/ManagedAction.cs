using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    public delegate void ManagedActionDelegate(JassTrigger trigger);

    public class ManagedAction : MarshalByRefObject
    {
        private ManagedActionDelegate action;

        public ManagedAction(ManagedActionDelegate action)
        {
            this.action = action;
        }

        public void Invoke(JassTrigger trigger)
        {
            this.action.Invoke(trigger);
        }
    }
}
