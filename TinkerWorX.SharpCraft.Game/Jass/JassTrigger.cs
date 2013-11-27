using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Htrigger;")]
    public struct JassTrigger
    {
        //native TriggerExecute takes trigger whichTrigger returns nothing
        private delegate void TriggerExecutePrototype(JassTrigger whichTrigger);
        private static TriggerExecutePrototype _TriggerExecute = WarcraftIII.Jass.GetNative("TriggerExecute").ToDelegate<TriggerExecutePrototype>();

        //native TriggerEvaluate takes trigger whichTrigger returns boolean
        private delegate JassBoolean TriggerEvaluatePrototype(JassTrigger whichTrigger);
        private static TriggerEvaluatePrototype _TriggerEvaluate = WarcraftIII.Jass.GetNative("TriggerEvaluate").ToDelegate<TriggerEvaluatePrototype>();

        private readonly IntPtr Handle;

        public JassTrigger(IntPtr handle)
        {
            this.Handle = handle;
        }

        public override String ToString()
        {
            return this.Handle.ToString();
        }

        public String ToString(String format)
        {
            return this.Handle.ToString(format);
        }

        public JassBoolean Evaluate()
        {
            return _TriggerEvaluate(this);
        }

        public void Execute()
        {
            _TriggerExecute(this);
        }
    }
}
