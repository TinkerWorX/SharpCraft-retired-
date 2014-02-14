using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hweapontype;")]
    [Serializable]
    public partial struct JassWeaponType
    {
        public readonly IntPtr Handle;
        
        public JassWeaponType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
