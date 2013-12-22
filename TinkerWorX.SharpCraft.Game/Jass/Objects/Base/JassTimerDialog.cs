using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htimerdialog;")]
    public partial struct JassTimerDialog
    {
        public readonly IntPtr Handle;
        
        public JassTimerDialog(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
