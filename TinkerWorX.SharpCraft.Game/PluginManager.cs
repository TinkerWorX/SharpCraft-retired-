using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using Microsoft.CSharp;

namespace TinkerWorX.SharpCraft.Game
{
    internal class PluginManager
    {
        private String pluginsFolder;

        private List<GamePluginBase> plugins;

        private List<String> pluginPaths;

        private CSharpCodeProvider provider;

        private CompilerParameters compilerParams;

        public PluginManager()
        {
            this.plugins = new List<GamePluginBase>();
            this.pluginPaths = new List<String>();
            this.provider = new CSharpCodeProvider();
            this.compilerParams = new CompilerParameters
            {
                ReferencedAssemblies = {
                    "System.dll",
                    "System.Core.dll",
                    Path.Combine(WarcraftIII.HackPath, "EasyHook.dll"),
                    Path.Combine(WarcraftIII.HackPath, "SharpCraft.Game.dll")
                }
            };
        }

        public void LoadPlugins()
        {
            this.pluginsFolder = Path.Combine(WarcraftIII.HackPath, "plugins");

            if (!Directory.Exists(this.pluginsFolder))
                return;

            foreach (var file in Directory.GetFiles(this.pluginsFolder))
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
            Trace.Write(" - - Compiling " + Path.GetFileNameWithoutExtension(path) + " . . . ");
            var results = this.CompilePlugin(path);
            if (results.Errors.HasErrors)
            {
                Trace.WriteLine("Failed! (script error)");
                using (var stream = File.Open(Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".errors.log"), FileMode.Create, FileAccess.Write, FileShare.Write))
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var error in results.Errors)
                    {
                        writer.WriteLine(error.ToString());
                    }
                }
                return;
            }

            // Convert the path URI to a normal path.
            var localPath = new Uri(results.CompiledAssembly.CodeBase).LocalPath;
            var pluginType = results.CompiledAssembly.GetTypes().FirstOrDefault(type => typeof(GamePluginBase).IsAssignableFrom(type));
            if (pluginType == null)
            {
                Trace.WriteLine("Failed! (interface missing)");
                return;
            }
            this.plugins.Add((GamePluginBase)AppDomain.CurrentDomain.CreateInstanceFrom(localPath, pluginType.FullName).Unwrap());

            Trace.WriteLine("Success!");
        }

        public void InitializePlugins()
        {
            foreach (var plugin in this.plugins)
            {
                Trace.Write(" - - Initializing \"" + plugin.Name + "\" . . . ");
                plugin.Initialize();
                Trace.WriteLine("Done!");
            }
        }
    }
}
