using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hgroup;")]
    [Serializable]
    public partial struct JassGroup
    {
        public readonly IntPtr Handle;
        
        public JassGroup(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
