using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces
{
    public interface IInputFullAPI : IInputSafeAPI
    {
        event MouseClickEventHandler MouseClick;

        event MouseWheelEventHandler MouseWheel;

        event KeyboardKeyEventHandler KeyboardKey;

        event PlayerChatEventHandler PlayerChat;
    }
}
