using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hmapvisibility;")]
    [Serializable]
    public partial struct JassMapVisibility
    {
        public readonly IntPtr Handle;
        
        public JassMapVisibility(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
