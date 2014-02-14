using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hmapflag;")]
    [Serializable]
    public partial struct JassMapFlag
    {
        public readonly IntPtr Handle;
        
        public JassMapFlag(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
