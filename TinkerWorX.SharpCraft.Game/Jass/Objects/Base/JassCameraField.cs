using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hcamerafield;")]
    public partial struct JassCameraField
    {
        public readonly IntPtr Handle;
        
        public JassCameraField(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
