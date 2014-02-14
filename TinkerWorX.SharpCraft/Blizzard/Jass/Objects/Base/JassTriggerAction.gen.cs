using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Htriggeraction;")]
    [Serializable]
    public partial struct JassTriggerAction
    {
        public readonly IntPtr Handle;
        
        public JassTriggerAction(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
