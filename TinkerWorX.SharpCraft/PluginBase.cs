using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    public abstract class PluginBase
    {
        public virtual void Initialize(PluginContext context) { }

        public virtual void OnGameLoad(PluginContext context) { }
    }
}
