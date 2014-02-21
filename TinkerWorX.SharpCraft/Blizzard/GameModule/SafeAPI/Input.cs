using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI
{
    public class Input : MarshalByRefObject
    {
        private static Input instance;

        internal Input() { }

        internal static void Initialize()
        {
            Input.instance = (Input)AppDomain.CurrentDomain.GetData(typeof(Input).FullName.ToLower());
            if (Input.instance == null)
                Trace.WriteLine("Attempted to initialize " + typeof(Input).Name + " in an invalid state.");
        }

        private Point2 mouseWindow
        {
            get { return InternalInput.MouseWindow; }
        }

        private Boolean isMouseOverUI
        {
            get { return InternalInput.IsMouseOverUI; }
        }

        private Vector2 mouseUI
        {
            get { return InternalInput.MouseUI; }
        }

        private Boolean blockChat
        {
            get { return InternalInput.BlockChat; }
            set { InternalInput.BlockChat = value; }
        }

        private Vector3 mouseTerrain
        {
            get { return InternalInput.MouseTerrain; }
        }

        public static Point2 MouseWindow
        {
            get { return Input.instance.mouseWindow; }
        }

        public static Boolean IsMouseOverUI
        {
            get { return Input.instance.isMouseOverUI; }
        }

        public static Vector2 MouseUI
        {
            get { return Input.instance.mouseUI; }
        }

        public static Vector3 MouseTerrain
        {
            get { return Input.instance.mouseTerrain; }
        }

        public static Boolean BlockChat
        {
            get { return Input.instance.blockChat; }
            set { Input.instance.blockChat = value; }
        }
    }
}
