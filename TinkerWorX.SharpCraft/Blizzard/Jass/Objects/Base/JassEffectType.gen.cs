using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Heffecttype;")]
    [Serializable]
    public partial struct JassEffectType
    {
        public readonly IntPtr Handle;
        
        public JassEffectType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
