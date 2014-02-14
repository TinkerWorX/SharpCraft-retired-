using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayer
    {
        public static JassPlayer FromLocal()
        {
            return Natives.GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return Natives.Player(index);
        }

        public Int32 Index { get { return this.GetIndex(); } }

        public Int32 GetIndex()
        {
            return Natives.GetPlayerId(this);
        }

        public Int32 Team
        {
            get { return this.GetTeam(); }
            set { this.SetTeam(value); }
        }

        public Int32 GetTeam()
        {
            return Natives.GetPlayerTeam(this);
        }

        public void SetTeam(Int32 team)
        {
            Natives.SetPlayerTeam(this, team);
        }

        public Int32 StartLocation
        {
            get { return this.GetStartLocation(); }
            set { this.SetStartLocation(value); }
        }

        public Int32 GetStartLocation()
        {
            return Natives.GetPlayerStartLocation(this);
        }

        public void SetStartLocation(Int32 locationIndex)
        {
            Natives.SetPlayerStartLocation(this, locationIndex);
        }

        public String Name
        {
            get { return this.GetName(); }
            set { this.SetName(value); }
        }

        public String GetName()
        {
            return Natives.GetPlayerName(this);
        }

        public void SetName(String name)
        {
            Natives.SetPlayerName(this, name);
        }
    }
}
