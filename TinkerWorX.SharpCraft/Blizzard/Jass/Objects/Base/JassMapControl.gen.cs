using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
