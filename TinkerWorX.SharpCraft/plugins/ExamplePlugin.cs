using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Game;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.ExamplePlugin
{
    public class ExamplePlugin : GamePluginBase
    {
        public override String Name { get { return "The Example Plugin"; } }

        public override Version Version { get { return new Version(0, 0); } }

        //native Cheat takes string cheatStr returns nothing
        private delegate void CheatPrototype(JassStringArg cheatStr);
        private static CheatPrototype Cheat = WarcraftIII.GetNative("Cheat").ToDelegate<CheatPrototype>();

        // native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing 
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private static DisplayTextToPlayerPrototype DisplayTextToPlayer = WarcraftIII.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();

        public void CheatHook(JassStringArg cheatStr)
        {
            switch (cheatStr)
            {
                case "mapinit":
                    DisplayTextToPlayer(JassPlayer.FromLocal(), 0, 0, "You started a map!");
                    break;

                case "tick":

                    break;

                case "esc":
                    var footman1 = JassUnit.Create(JassPlayer.FromIndex(0), (JassUnitId)"hfoo", 0, 0, 0);
                    var footman2 = JassUnit.Create(JassPlayer.FromIndex(1), (JassUnitId)"hfoo", 0, 0, 0);
                    DisplayTextToPlayer(JassPlayer.FromLocal(), 0, 0, "You hit |cffffcc00ESC|r!");
                    break;

                default:
                    Cheat(cheatStr);
                    break;
            }
        }

        public override void Initialize()
        {
            // Override the original cheat native, so we can intercept calls.
            WarcraftIII.AddNative(new CheatPrototype(this.CheatHook), "Cheat");

            WarcraftIII.GameStart += delegate { Console.WriteLine("GameStart"); };
            WarcraftIII.MapStart += delegate { Console.WriteLine("MapStart"); };
            WarcraftIII.MapEnd += delegate { Console.WriteLine("MapEnd"); };
            WarcraftIII.GameEnd += delegate { Console.WriteLine("GameEnd"); };
        }
    }
}
