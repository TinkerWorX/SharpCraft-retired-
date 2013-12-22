using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hconditionfunc;")]
    public partial struct JassConditionFunction
    {
        public readonly IntPtr Handle;
        
        public JassConditionFunction(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
