using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.Storm
{
    public unsafe class SStr
    {
        [DllImport("storm.dll", EntryPoint = "#590")]
        public static extern int HashHT([In] char* input);

        [DllImport("storm.dll", EntryPoint = "#590")]
        public static extern int HashHT([In] string input);


        private SStr() { }
    }
}
