using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.FullAPI
{
    public partial class Natives : MarshalByRefObject
    {
        internal Natives() { }

        public static void Add(Delegate function, String name, String prototype)
        {
            InternalNatives.Add(function, name, prototype);
        }

        public static void Add(Delegate function, String name)
        {
            InternalNatives.Add(function, name);
        }

        public static void Add(Delegate function)
        {
            InternalNatives.Add(function);
        }
    }
}
