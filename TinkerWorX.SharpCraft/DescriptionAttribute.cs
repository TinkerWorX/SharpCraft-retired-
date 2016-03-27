using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class DescriptionAttribute : Attribute
    {
        private readonly String text;

        public DescriptionAttribute(String text)
        {
            this.text = text;
        }

        public String Text { get { return this.text; } }
    }
}
