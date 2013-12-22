using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmapsetting;")]
    [Serializable]
    public partial struct JassMapSetting
    {
        public readonly IntPtr Handle;
        
        public JassMapSetting(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
