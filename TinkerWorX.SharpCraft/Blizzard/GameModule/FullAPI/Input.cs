using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.FullAPI
{
    public class Input : MarshalByRefObject
    {
        internal Input() { }

        public static Point2 MouseWindow
        {
            get { return InternalInput.MouseWindow; }
        }

        public static Boolean IsMouseOverUI
        {
            get { return InternalInput.IsMouseOverUI; }
        }

        public static Vector2 MouseUI
        {
            get { return InternalInput.MouseUI; }
        }

        public static Vector3 MouseTerrain
        {
            get { return InternalInput.MouseTerrain; }
        }

        public static Boolean BlockChat
        {
            get { return InternalInput.BlockChat; }
            set { InternalInput.BlockChat = value; }
        }

        public static event MouseClickEventHandler MouseClick
        {
            add { InternalInput.MouseClick += value; }
            remove { InternalInput.MouseClick -= value; }
        }

        public static event MouseWheelEventHandler MouseWheel
        {
            add { InternalInput.MouseWheel += value; }
            remove { InternalInput.MouseWheel -= value; }
        }

        public static event KeyboardKeyEventHandler KeyboardKey
        {
            add { InternalInput.KeyboardKey += value; }
            remove { InternalInput.KeyboardKey -= value; }
        }

        public static event PlayerChatEventHandler PlayerChat
        {
            add { InternalInput.PlayerChat += value; }
            remove { InternalInput.PlayerChat -= value; }
        }
    }
}
