using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
