using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hdamagetype;")]
    [Serializable]
    public partial struct JassDamageType
    {
        public readonly IntPtr Handle;
        
        public JassDamageType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
