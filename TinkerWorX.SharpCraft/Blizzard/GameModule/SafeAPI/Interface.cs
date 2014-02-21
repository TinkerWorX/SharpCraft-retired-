using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI
{
    public class Interface : MarshalByRefObject
    {
        private static Interface instance;

        internal Interface() { }

        public static void Initialize()
        {
            Interface.instance = (Interface)AppDomain.CurrentDomain.GetData(typeof(Interface).FullName.ToLower());
            if (Interface.instance == null)
                Trace.WriteLine("Attempted to initialize " + typeof(Interface).Name + " in an invalid state.");
        }

        private Single fps
        {
            get { return InternalInterface.FPS; }
        }

        public static Single FPS
        {
            get { return Interface.instance.fps; }
        }
    }
}
