using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI
{
    public class Script : MarshalByRefObject
    {
        private static Script instance;

        internal Script() { }

        public static void Initialize()
        {
            Script.instance = (Script)AppDomain.CurrentDomain.GetData(typeof(Script).FullName.ToLower());
            if (Script.instance == null)
                Trace.WriteLine("Attempted to use " + typeof(Script).Name + " in an invalid state.");
        }
    }
}
