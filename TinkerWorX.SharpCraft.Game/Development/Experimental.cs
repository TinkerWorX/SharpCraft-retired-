using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Game;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game.Development
{
    // This is a temporary way of adding new stuff.
    // This will get replaced with a plugin system.
    internal class Experimental : IGamePlugin
    {
        // native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing 
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private DisplayTextToPlayerPrototype displayTextToPlayer = Native.FromString("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();

        //native Cheat takes string cheatStr returns nothing
        private delegate void CheatPrototype(JassStringArg cheatStr);
        private CheatPrototype cheat = Native.FromString("Cheat").ToDelegate<CheatPrototype>();

        public void CheatHook(JassStringArg cheatStr)
        {
            switch (cheatStr)
            {
                case "mapinit":
                    displayTextToPlayer(JassPlayer.Local, 0, 0, "You started a map!");
                    break;

                case "tick":

                    break;

                case "esc":
                    var footman1 = JassUnit.Create(JassPlayer.FromIndex(0), (JassUnitId)"hfoo", 0, 0, 0);
                    var footman2 = JassUnit.Create(JassPlayer.FromIndex(1), (JassUnitId)"hfoo", 0, 0, 0);
                    displayTextToPlayer(JassPlayer.Local, 0, 0, "You hit |cffffcc00ESC|r!");
                    break;

                default:
                    displayTextToPlayer(JassPlayer.Local, 0, 0, cheatStr);
                    break;
            }
        }

        public void Initialize()
        {
            WarcraftIII.AddNative(new CheatPrototype(CheatHook), "Cheat");

            WarcraftIII.GameStart += delegate { Console.WriteLine("GameStart"); };
            WarcraftIII.MapStart += delegate { Console.WriteLine("MapStart"); };
            WarcraftIII.MapEnd += delegate { Console.WriteLine("MapEnd"); };
            WarcraftIII.GameEnd += delegate { Console.WriteLine("GameEnd"); };
        }
    }

    [JassType("Hplayer;")]
    internal struct JassPlayer
    {
        // constant native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype GetLocalPlayer;

        // constant native Player takes integer number returns player
        private delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype Player;

        // native GetPlayerName takes player whichPlayer returns string
        private delegate JassStringRet GetPlayerNameDelegate(JassPlayer whichPlayer);
        private static GetPlayerNameDelegate GetPlayerName;

        // native GetPlayerName takes player whichPlayer returns string
        private delegate void SetPlayerNameDelegate(JassPlayer whichPlayer, JassStringArg name);
        private static SetPlayerNameDelegate SetPlayerName;

        public static JassPlayer Local
        {
            get
            {
                if (GetLocalPlayer == null)
                    GetLocalPlayer = Native.FromString("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();
                return GetLocalPlayer();
            }
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            if (Player == null)
                Player = Native.FromString("Player").ToDelegate<PlayerPrototype>();
            return Player(index);
        }

        private readonly IntPtr Handle;

        public String Name
        {
            get
            {
                if (GetPlayerName == null)
                    GetPlayerName = Native.FromString("GetPlayerName").ToDelegate<GetPlayerNameDelegate>();
                return GetPlayerName(this);
            }
            set
            {
                if (SetPlayerName == null)
                    SetPlayerName = Native.FromString("SetPlayerName").ToDelegate<SetPlayerNameDelegate>();
                SetPlayerName(this, value);
            }
        }
    }

    [JassType("Hunit;")]
    internal struct JassUnit
    {
        // native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitPrototype(JassPlayer id, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitPrototype CreateUnit;

        public static JassUnit Create(JassPlayer player, JassUnitId id, Single x, Single y, Single facing)
        {
            if (CreateUnit == null)
                CreateUnit = Native.FromString("CreateUnit").ToDelegate<CreateUnitPrototype>();
            return CreateUnit(player, id, x, y, facing);
        }

        private readonly IntPtr Handle;

    }
}
