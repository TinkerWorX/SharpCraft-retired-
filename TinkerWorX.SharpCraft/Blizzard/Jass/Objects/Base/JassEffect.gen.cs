using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Heffect;")]
    [Serializable]
    public partial struct JassEffect
    {
        public readonly IntPtr Handle;
        
        public JassEffect(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
