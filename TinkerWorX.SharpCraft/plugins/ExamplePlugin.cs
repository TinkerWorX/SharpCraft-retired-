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

        // constant native Player takes integer number returns player
        private delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype Player = WarcraftIII.GetNative("Player").ToDelegate<PlayerPrototype>();

        // constant native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype GetLocalPlayer = WarcraftIII.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();

        // native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing 
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private static DisplayTextToPlayerPrototype DisplayTextToPlayer = WarcraftIII.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();

        // native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitPrototype(JassPlayer id, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitPrototype CreateUnit = WarcraftIII.GetNative("CreateUnit").ToDelegate<CreateUnitPrototype>();

        public void CheatHook(JassStringArg cheatStr)
        {
            switch (cheatStr)
            {
                case "mapinit":
                    DisplayTextToPlayer(GetLocalPlayer(), 0, 0, "You started a map!");
                    break;

                case "tick":

                    break;

                case "esc":
                    var footman1 = CreateUnit(Player(0), (JassUnitId)"hfoo", 0, 0, 0);
                    var footman2 = CreateUnit(Player(1), (JassUnitId)"hfoo", 0, 0, 0);
                    DisplayTextToPlayer(GetLocalPlayer(), 0, 0, "You hit |cffffcc00ESC|r!");
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
