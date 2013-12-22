using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public partial struct JassTrigger
    {
        public JassBoolean Evaluate()
        {
            return WarcraftIII.Jass.Natives.TriggerEvaluate(this);
        }

        public void Execute()
        {
            WarcraftIII.Jass.Natives.TriggerExecute(this);
        }
    }
}
