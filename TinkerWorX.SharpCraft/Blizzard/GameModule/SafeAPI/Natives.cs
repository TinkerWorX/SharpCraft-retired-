using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI
{
    public partial class Natives : MarshalByRefObject
    {
        private static Natives instance;

        internal Natives() { }

        internal static void Initialize()
        {
            Natives.instance = (Natives)AppDomain.CurrentDomain.GetData(typeof(Natives).FullName.ToLower());
            if (Natives.instance == null)
                Trace.WriteLine("Attempted to initialize " + typeof(Natives).Name + " in an invalid state.");
        }
    }
}
