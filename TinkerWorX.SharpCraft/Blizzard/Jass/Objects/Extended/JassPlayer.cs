using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayer
    {
        public static JassPlayer FromLocal()
        {
            return SafeNatives.GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return SafeNatives.Player(index);
        }

        public Int32 Index { get { return this.GetIndex(); } }

        public Int32 GetIndex()
        {
            return SafeNatives.GetPlayerId(this);
        }

        public Int32 Team
        {
            get { return this.GetTeam(); }
            set { this.SetTeam(value); }
        }

        public Int32 GetTeam()
        {
            return SafeNatives.GetPlayerTeam(this);
        }

        public void SetTeam(Int32 team)
        {
            SafeNatives.SetPlayerTeam(this, team);
        }

        public Int32 StartLocation
        {
            get { return this.GetStartLocation(); }
            set { this.SetStartLocation(value); }
        }

        public Int32 GetStartLocation()
        {
            return SafeNatives.GetPlayerStartLocation(this);
        }

        public void SetStartLocation(Int32 locationIndex)
        {
            SafeNatives.SetPlayerStartLocation(this, locationIndex);
        }

        public String Name
        {
            get { return this.GetName(); }
            set { this.SetName(value); }
        }

        public String GetName()
        {
            return SafeNatives.GetPlayerName(this);
        }

        public void SetName(String name)
        {
            SafeNatives.SetPlayerName(this, name);
        }
    }
}
