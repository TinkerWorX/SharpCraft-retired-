using System;
using TinkerWorX.Blizzard.GameModule.Interfaces;
using TinkerWorX.Blizzard.GameModule.Jass;

public static class MapScript
{
    public static void Config(Boolean isInLobby)
    {
        Console.WriteLine("MapScript.Config(" + isInLobby + ")");
    }

    public static void Main()
    {
        Console.WriteLine("MapScript.Main()");
        JassUnit.Create(JassPlayer.FromIndex(0), (JassObjectId)"hpea", 0, 0, 0);
    }
}
