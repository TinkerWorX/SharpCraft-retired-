using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hcamerasetup;")]
    [Serializable]
    public partial struct JassCameraSetup
    {
        public readonly IntPtr Handle;
        
        public JassCameraSetup(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
