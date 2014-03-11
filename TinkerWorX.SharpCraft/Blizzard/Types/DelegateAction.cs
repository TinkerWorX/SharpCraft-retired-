using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.Types
{
    public delegate void DelegateActionDelegate(JassTrigger trigger);

    public delegate Boolean DelegateConditionDelegate(JassTrigger trigger);

    public class DelegateAction : ManagedActionBase
    {
        private DelegateConditionDelegate condition { get; set; }

        private DelegateActionDelegate action { get; set; }

        public DelegateAction(DelegateActionDelegate action)
        {
            if (action == null) throw new ArgumentNullException("action");

            this.condition = new DelegateConditionDelegate((trigger) => true);
            this.action = action;
        }

        public DelegateAction(DelegateConditionDelegate condition, DelegateActionDelegate action)
        {
            if (condition == null) throw new ArgumentNullException("condition");
            if (action == null) throw new ArgumentNullException("action");

            this.condition = condition;
            this.action = action;
        }

        public override Boolean Condition(JassTrigger trigger)
        {
            return this.condition(trigger);
        }

        public override void Action(JassTrigger trigger)
        {
            this.action(trigger);
        }
    }
}
