using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft
{
    public abstract class SafePluginBase : MarshalByRefObject
    {
        public IInputSafeAPI Input { get; internal set; }

        public IInterfaceSafeAPI Interface { get; internal set; }

        public IJassSafeAPI Jass { get; internal set; }

        public INativesSafeAPI Natives { get; internal set; }

        public virtual void Initialize() { }

        public virtual void OnGameReady() { }

        public virtual void CheatCallback(String cheat) { }

        public virtual void CreateUnitCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void CreateCorpseCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void RemoveUnitCallback(JassUnit unit) { }

        public virtual void OnPreConfig(Boolean isInLobby) { }

        public virtual void OnPostConfig(Boolean isInLobby) { }

        public virtual void OnPreMain() { }

        public virtual void OnPostMain() { }

        public virtual void OnMouseClick(MouseButton button, MouseButtonState state, Point2 point) { }

        public virtual void OnMouseWheel(Int32 delta) { }

        public virtual void OnKeyboardKey(Int32 key, Char keyChar, KeyboardKeyState state) { }

        public virtual void OnPlayerChat(Int32 sender, String message, ChatRecipients recipients) { }
    }
}
