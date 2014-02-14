using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hquest;")]
    [Serializable]
    public partial struct JassQuest
    {
        public readonly IntPtr Handle;
        
        public JassQuest(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
