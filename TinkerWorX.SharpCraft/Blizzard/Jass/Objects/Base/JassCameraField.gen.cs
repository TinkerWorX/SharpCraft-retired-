using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hcamerafield;")]
    [Serializable]
    public partial struct JassCameraField
    {
        public readonly IntPtr Handle;
        
        public JassCameraField(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
