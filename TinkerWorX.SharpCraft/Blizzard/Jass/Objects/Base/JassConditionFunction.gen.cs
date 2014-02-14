using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hconditionfunc;")]
    [Serializable]
    public partial struct JassConditionFunction
    {
        public readonly IntPtr Handle;
        
        public JassConditionFunction(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
