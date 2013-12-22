using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmapcontrol;")]
    public partial struct JassMapControl
    {
        public readonly IntPtr Handle;
        
        public JassMapControl(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
