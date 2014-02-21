using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassTrigger
    {
        public JassBoolean Evaluate()
        {
            return SafeNatives.TriggerEvaluate(this);
        }

        public void Execute()
        {
            SafeNatives.TriggerExecute(this);
        }
    }
}
