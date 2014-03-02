using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.Types;

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

        private void triggerAddAction(JassTrigger trigger, ManagedAction action)
        {
            InternalNatives.TriggerAddAction(trigger, action);
        }

        public static void TriggerAddAction(JassTrigger trigger, ManagedAction action)
        {
            Natives.instance.triggerAddAction(trigger, action);
        }
    }
}
