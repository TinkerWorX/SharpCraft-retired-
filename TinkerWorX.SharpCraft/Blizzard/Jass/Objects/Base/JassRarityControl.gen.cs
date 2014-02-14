using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hraritycontrol;")]
    [Serializable]
    public partial struct JassRarityControl
    {
        public readonly IntPtr Handle;
        
        public JassRarityControl(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
