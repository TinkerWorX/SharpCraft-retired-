using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htriggercondition;")]
    [Serializable]
    public partial struct JassTriggerCondition
    {
        public readonly IntPtr Handle;
        
        public JassTriggerCondition(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
