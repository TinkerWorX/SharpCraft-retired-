using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hdialog;")]
    public partial struct JassDialog
    {
        public readonly IntPtr Handle;
        
        public JassDialog(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
