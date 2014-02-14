using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassTrigger
    {
        public JassBoolean Evaluate()
        {
            return Natives.TriggerEvaluate(this);
        }

        public void Execute()
        {
            Natives.TriggerExecute(this);
        }
    }
}
