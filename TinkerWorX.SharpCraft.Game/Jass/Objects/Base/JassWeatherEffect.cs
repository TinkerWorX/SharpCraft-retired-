using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hweathereffect;")]
    [Serializable]
    public partial struct JassWeatherEffect
    {
        public readonly IntPtr Handle;
        
        public JassWeatherEffect(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
