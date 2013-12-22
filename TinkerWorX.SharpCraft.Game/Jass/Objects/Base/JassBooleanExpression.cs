using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hboolexpr;")]
    [Serializable]
    public partial struct JassBooleanExpression
    {
        public readonly IntPtr Handle;
        
        public JassBooleanExpression(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
