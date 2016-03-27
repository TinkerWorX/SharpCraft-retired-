using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class SupportAttribute : Attribute
    {
        private readonly String version;

        private readonly SupportRange range;

        private readonly Boolean isSupported;

        private readonly Boolean isTested;

        public SupportAttribute(String version, SupportRange range, Boolean isSupported, Boolean isTested)
        {
            this.version = version;
            this.range = range;
            this.isSupported = isSupported;
            this.isTested = isTested;
        }

        public Version Version { get { return new Version(this.version); } }

        public SupportRange State { get { return this.range; } }

        public Boolean IsSupported { get { return this.isSupported; } }

        public Boolean IsTested { get { return this.isTested; } }
    }

    [Flags]
    public enum SupportRange : byte
    {
        None = 0x00,

        Below = 1 << 1,
        Current = 1 << 2,
        Above = 1 << 3,
    }
}
