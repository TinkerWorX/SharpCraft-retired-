using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.APIs
{
    internal class InputAPI : MarshalByRefObject, IInputSafeAPI, IInputFullAPI
    {
        public Point2 MouseWindow
        {
            get { return Input.MouseWindow; }
        }

        public Boolean IsMouseOverUI
        {
            get { return Input.IsMouseOverUI; }
        }

        public Vector2 MouseUI
        {
            get { return Input.MouseUI; }
        }

        public Vector3 MouseTerrain
        {
            get { return Input.MouseTerrain; }
        }

        public Boolean BlockChat
        {
            get { return Input.BlockChat; }
            set { Input.BlockChat = value; }
        }

        public event MouseClickEventHandler MouseClick
        {
            add { Input.MouseClick += value; }
            remove { Input.MouseClick -= value; }
        }

        public event MouseWheelEventHandler MouseWheel
        {
            add { Input.MouseWheel += value; }
            remove { Input.MouseWheel -= value; }
        }

        public event KeyboardKeyEventHandler KeyboardKey
        {
            add { Input.KeyboardKey += value; }
            remove { Input.KeyboardKey -= value; }
        }

        public event PlayerChatEventHandler PlayerChat
        {
            add { Input.PlayerChat += value; }
            remove { Input.PlayerChat -= value; }
        }
    }
}
