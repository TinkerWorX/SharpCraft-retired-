using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft
{
    public abstract class MapPluginBase : MarshalByRefObject
    {
        internal void InternalInitialize()
        {
            Input.Initialize();
            Interface.Initialize();
            Natives.Initialize();
            Script.Initialize();
        }

        public virtual void Config(Boolean isInLobby) { }

        public virtual void Main() { }

        public virtual void CheatCallback(String cheat) { }

        public virtual void CreateUnitCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void CreateCorpseCallback(JassUnit unit, JassPlayer owner, JassObjectId id, Single x, Single y, Single facing) { }

        public virtual void RemoveUnitCallback(JassUnit unit) { }

        public virtual void OnMouseClick(MouseButton button, MouseButtonState state, Point2 point) { }

        public virtual void OnMouseWheel(Int32 delta) { }

        public virtual void OnKeyboardKey(Int32 key, Char keyChar, KeyboardKeyState state) { }

        public virtual void OnPlayerChat(Int32 sender, String message, ChatRecipients recipients) { }
    }
}
