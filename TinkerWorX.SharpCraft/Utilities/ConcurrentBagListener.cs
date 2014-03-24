using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace TinkerWorX.SharpCraft.Utilities
{
    public class ConcurrentBagListener : TraceListener
    {
        public ConcurrentBag<String> Messages { get; private set; }

        private Boolean isNewline = true;

        public ConcurrentBagListener()
        {
            this.Messages = new ConcurrentBag<String>();
        }

        public override void Write(String message)
        {
            var indent = String.Empty;
            if (this.isNewline)
                indent = new String(' ', this.IndentSize * this.IndentLevel);
            this.Messages.Add(indent + message);
            this.isNewline = false;
        }

        public override void WriteLine(String message)
        {
            this.Write(message + Environment.NewLine);
            this.isNewline = true;
        }
    }
}
