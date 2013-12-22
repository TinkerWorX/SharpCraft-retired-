using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hability;")]
    [Serializable]
    public partial struct JassAbility
    {
        public readonly IntPtr Handle;
        
        public JassAbility(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
