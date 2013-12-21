using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hattacktype;")]
    public partial struct JassAttackType
    {
        public readonly IntPtr Handle;
        
        public JassAttackType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
