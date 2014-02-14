namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    public enum CodeResult : int
    {
        Success = 1,
        OpLimit = 2,
        ThreadPause = 3,
        ThreadSync = 4,
        VariableUninitialized = 6,
        DivideByZero = 7,
    }
}
