using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CSharp;

namespace TinkerWorX.SharpCraft.Game
{
    internal class PluginManager
    {
        private List<GamePluginBase> plugins;

        private CSharpCodeProvider provider;

        private CompilerParameters compilerParams;

        public PluginManager()
        {
            this.plugins = new List<GamePluginBase>();
            this.provider = new CSharpCodeProvider();
            this.compilerParams = new CompilerParameters
            {
                ReferencedAssemblies = {
                    "System.dll",
                    "System.Core.dll",
                    Path.Combine(WarcraftIII.HackPath, "SharpCraft.Game.dll")
                }
            };
        }

        public void LoadPlugins(String folder)
        {
            if (!Directory.Exists(folder))
                return;

            foreach (var file in Directory.GetFiles(folder))
            {
                if (Path.GetExtension(file) == ".cs")
                    this.LoadPlugin(file);
            }
        }

        private CompilerResults CompilePlugin(String path)
        {
            using (var reader = File.OpenText(path))
            {
                return this.provider.CompileAssemblyFromSource(this.compilerParams, reader.ReadToEnd());
            }
        }

        private void LoadPlugin(String path)
        {
            Debug.WriteLine(" . Compiling " + Path.GetFileName(path) + " . . .");
            var results = this.CompilePlugin(path);
            if (results.Errors.HasErrors)
            {
                Debug.WriteLine(" . - Failed!");
                return;
            }
            Debug.WriteLine(" . - Succes!");
        }

        public void InitializePlugins()
        {
            foreach (var plugin in this.plugins)
                plugin.Initialize();
        }
    }
}
