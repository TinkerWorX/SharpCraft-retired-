using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [AttributeUsage(AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    sealed class JassTypeAttribute : Attribute
    {
        public readonly String TypeString;

        public JassTypeAttribute(string typeString)
        {
            this.TypeString = typeString;
        }
    }
}
