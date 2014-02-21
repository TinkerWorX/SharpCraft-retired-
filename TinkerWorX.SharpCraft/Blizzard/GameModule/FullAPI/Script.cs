using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.FullAPI
{
    public class Script : MarshalByRefObject
    {
        internal Script() { }

        public static event Action PreConfig
        {
            add { InternalScript.PreConfig += value; }
            remove { InternalScript.PreConfig -= value; }
        }

        public static event Action PostConfig
        {
            add { InternalScript.PostConfig += value; }
            remove { InternalScript.PostConfig -= value; }
        }

        public static event Action PreMain
        {
            add { InternalScript.PreMain += value; }
            remove { InternalScript.PreMain -= value; }
        }

        public static event Action PostMain
        {
            add { InternalScript.PostMain += value; }
            remove { InternalScript.PostMain -= value; }
        }
    }
}
