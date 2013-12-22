using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmapcontrol;")]
    [Serializable]
    public partial struct JassMapControl
    {
        public readonly IntPtr Handle;
        
        public JassMapControl(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
