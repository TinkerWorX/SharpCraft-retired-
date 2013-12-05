using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using TinkerWorX.SharpCraft.Game;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.ExamplePlugin
{
    public class ExamplePlugin : GamePluginBase
    {
        //native Cheat takes string cheatStr returns nothing
        private delegate void CheatPrototype(JassStringArg cheatStr);
        private static CheatPrototype Cheat/* = WarcraftIII.GetNative("Cheat").ToDelegate<CheatPrototype>()*/;

        // native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing 
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private static DisplayTextToPlayerPrototype DisplayTextToPlayer/* = WarcraftIII.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>()*/;

        // GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype GetLocalPlayer;

        public override String Name { get { return "The Example Plugin"; } }

        public override Version Version { get { return new Version(0, 0); } }

        private List<JassUnit> units = new List<JassUnit>();

        private Single DegreeToRadian(Single angle)
        {
            return (Single)Math.PI * angle / 180.00f;
        }

        private Single RadianToDegree(Single angle)
        {
            return angle * (180.00f / (Single)Math.PI);
        }

        public void CheatHook(JassStringArg cheatStr)
        {
            Console.WriteLine(cheatStr);
            switch (cheatStr)
            {
                case "mapinit":
                    //DisplayTextToPlayer(JassPlayer.FromLocal(), 0, 0, "You started a map!");
                    //DisplayTextToPlayer(JassPlayer.FromLocal(), 0, 0, "Hit |cffffcc00ESC|r to spawn some units under your cursor!");
                    break;

                case "tick":
                    //const Single dt = 0.01f; // this is how often the timer is updating.
                    //const Single speed = 128.00f; // this is how far we want the unit to move per second.
                    //foreach (var unit in this.units)
                    //{
                    //    var facing = unit.GetFacing();
                    //    unit.SetX(unit.GetX() + speed * dt * (Single)Math.Cos(DegreeToRadian(facing)));
                    //    unit.SetY(unit.GetY() + speed * dt * (Single)Math.Sin(DegreeToRadian(facing)));
                    //}
                    break;

                case "esc":
                    //var random = new Random();
                    //this.units.Add(JassUnit.Create(JassPlayer.FromIndex(0), (JassUnitId)"hfoo", WarcraftIII.MouseTerrain.X, WarcraftIII.MouseTerrain.Y, random.Next() * 360));
                    //this.units.Add(JassUnit.Create(JassPlayer.FromIndex(1), (JassUnitId)"hfoo", WarcraftIII.MouseTerrain.X, WarcraftIII.MouseTerrain.Y, random.Next() * 360));
                    //this.units.Add(JassUnit.Create(JassPlayer.FromIndex(2), (JassUnitId)"hfoo", WarcraftIII.MouseTerrain.X, WarcraftIII.MouseTerrain.Y, random.Next() * 360));
                    //this.units.Add(JassUnit.Create(JassPlayer.FromIndex(3), (JassUnitId)"hfoo", WarcraftIII.MouseTerrain.X, WarcraftIII.MouseTerrain.Y, random.Next() * 360));
                    //DisplayTextToPlayer(JassPlayer.FromLocal(), 0, 0, "You hit |cffffcc00ESC|r!");
                    break;

                default:
                    //Cheat(cheatStr);
                    break;
            }
        }

        public override void Initialize(IGameAPI api)
        {
            //Cheat = WarcraftIII.GetNative("Cheat").ToDelegate<CheatPrototype>();
            //DisplayTextToPlayer = api.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();
            //GetLocalPlayer = api.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();
            //WarcraftIII.MapStart += this.MapStart;
            //Console.WriteLine(Cheat);
            //Trace.WriteLine("Foo");
            //api.test("Bar");
            //(AppDomain.CurrentDomain.GetData("api") as IGameAPI).test("test");

            // Override the original cheat native, so we can intercept calls.
            api.AddNative(new CheatPrototype(this.CheatHook), "Cheat");
        }

        public void MapStart()
        {
            //this.units.Clear();
        }
    }
}
