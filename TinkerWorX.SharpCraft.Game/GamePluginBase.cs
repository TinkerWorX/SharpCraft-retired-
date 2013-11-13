using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game
{
    public abstract class GamePluginBase : MarshalByRefObject
    {
        public abstract String Name { get; }

        public abstract Version Version { get; }

        public virtual void Initialize() { }
    }
}
