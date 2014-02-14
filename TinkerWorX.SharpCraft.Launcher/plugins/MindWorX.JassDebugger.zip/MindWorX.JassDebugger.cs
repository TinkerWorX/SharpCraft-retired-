using System;
using TinkerWorX.Blizzard;
using TinkerWorX.Blizzard.GameModule.Types;
using TinkerWorX.Blizzard.Types;
using TinkerWorX.SharpCraft.Plugins;
using TinkerWorX.Utilities;

namespace MindWorX.JassDebugger
{
    unsafe public class JassDebugger : FullPluginBase
    {
        public override String Name { get { return "Jass Debugger"; } }

        public override Version Version { get { return new Version(0, 0, 0, 0); } }

        public override void Initialize()
        {
            Game.Jass.VirtualMachine__RunCodeCallback += Jass_VirtualMachine__RunCodeCallback;
        }

        void Jass_VirtualMachine__RunCodeCallback(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5, CodeResult result)
        {
            // -8 is the start of the function declaration op.
            // -4 is the function id.
            // -0 is the first instruction in the function.
            var functionId = Memory.Read<Int32>(opCode - 0x04);
            var functionName = virtualMachine.AsUnsafe()->SymbolTable->StringPool->Nodes[functionId]->Value;
            switch (result)
            {
                case CodeResult.Success: break;
                case CodeResult.OpLimit:
                    Game.Interface.GameUI.ChatMessage.WriteLine("[Debugger] |cffff0000Error|r: Op limit(" + opLimit + ") exceeded in " + functionName, Color.White, 10.00f);
                    break;
                case CodeResult.ThreadPause: break;
                case CodeResult.ThreadSync: break;
                case CodeResult.VariableUninitialized:
                    Game.Interface.GameUI.ChatMessage.WriteLine("[Debugger] |cffff0000Error|r: Uninitialized variable read in " + functionName, Color.White, 10.00f);
                    break;
                case CodeResult.DivideByZero:
                    Game.Interface.GameUI.ChatMessage.WriteLine("[Debugger] |cffff0000Error|r: Divide by zero in " + functionName, Color.White, 10.00f);
                    break;
                default:
                    Game.Interface.GameUI.ChatMessage.WriteLine("[Debugger] |cffff0000Error|r: Unknown error(" + result + ") in " + functionName, Color.White, 10.00f);
                    break;
            }
        }
    }
}
