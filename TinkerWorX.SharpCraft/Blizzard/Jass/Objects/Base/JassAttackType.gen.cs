using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hattacktype;")]
    [Serializable]
    public partial struct JassAttackType
    {
        public readonly IntPtr Handle;
        
        public JassAttackType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
