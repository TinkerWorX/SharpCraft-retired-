using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class AuthorAttribute : Attribute
    {
        private readonly String name;

        public AuthorAttribute(String name)
        {
            this.name = name;
        }

        public String Name { get { return this.name; } }
    }
}
