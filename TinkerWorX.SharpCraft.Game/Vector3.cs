using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft.Game
{
    public struct Vector3
    {
        public Single X;

        public Single Y;

        public Single Z;

        public Vector3(Single x, Single y, Single z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3(Vector2 vector, Single z)
        {
            this.X = vector.X;
            this.Y = vector.Y;
            this.Z = z;
        }
    }
}
