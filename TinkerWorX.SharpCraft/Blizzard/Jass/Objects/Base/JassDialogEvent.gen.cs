using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hdialogevent;")]
    [Serializable]
    public partial struct JassDialogEvent
    {
        public readonly IntPtr Handle;
        
        public JassDialogEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
