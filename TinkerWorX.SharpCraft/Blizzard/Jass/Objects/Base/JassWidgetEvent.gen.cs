using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hwidgetevent;")]
    [Serializable]
    public partial struct JassWidgetEvent
    {
        public readonly IntPtr Handle;
        
        public JassWidgetEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
