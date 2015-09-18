using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    public interface IPlugin
    {
        void Initialize(PluginContext context);

        void OnGameLoad(PluginContext context);
    }
}
