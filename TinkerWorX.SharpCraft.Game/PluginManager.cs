using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using TinkerWorX.SharpCraft.Core;
using Assembly = System.Reflection.Assembly;

namespace TinkerWorX.SharpCraft.Game
{
    internal class PluginManager : MarshalByRefObject
    {
        private String pluginsFolder;

        private String sandboxFolder;

        private List<GamePluginBase> plugins;

        private List<String> pluginPaths;

        private CSharpCodeProvider provider;

        private CompilerParameters compilerParams;

        private AppDomainSetup appDomainSetup;

        private Evidence sandboxEvidence;

        private PermissionSet permissionSet;

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
                    Path.Combine(WarcraftIII.HackPath, "Lidgren.Network.dll"),
                    Path.Combine(WarcraftIII.HackPath, "SharpCraft.Game.dll")
                },
                CompilerOptions = "/unsafe"
            };
        }

        public void LoadPlugins()
        {
            this.pluginsFolder = Path.Combine(WarcraftIII.HackPath, "plugins");

            if (!Directory.Exists(this.pluginsFolder))
            {
                Trace.WriteLine(" - - \"plugins\" folder missing!");
                return;
            }

            this.sandboxFolder = Path.Combine(WarcraftIII.HackPath, "sandbox");
            if (!Directory.Exists(this.sandboxFolder))
                Directory.CreateDirectory(this.sandboxFolder);

            // Prepare the sandbox.
            this.appDomainSetup = new AppDomainSetup()
            {
                ApplicationName = "SharpCraft Scripting Application",
                ApplicationBase = WarcraftIII.HackPath,
                DynamicBase = WarcraftIII.HackPath
            };
            this.sandboxEvidence = new Evidence();
            switch (Settings.Current.SecurityZone)
            {
                /*case SecurityZone.Trusted:
                    this.sandboxEvidence.AddHostEvidence(new Zone(SecurityZone.Trusted));
                    break;*/
                default:
                    //this.sandboxEvidence.AddHostEvidence(new Zone(SecurityZone.Untrusted));
                    this.sandboxEvidence.AddHostEvidence(new Zone(SecurityZone.MyComputer));
                    break;
            }

            // We get a standard sandbox permission set.
            this.permissionSet = SecurityManager.GetStandardSandbox(this.sandboxEvidence);

            // Add global Execution permission to run the assembly.
            this.permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));

            // The script assembly itself needs Read and PathDiscovery access.

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
                this.compilerParams.OutputAssembly = Path.Combine(this.pluginsFolder, Path.GetFileNameWithoutExtension(path) + ".dll");
                return this.provider.CompileAssemblyFromSource(this.compilerParams, reader.ReadToEnd());
            }
        }

        private void LoadPlugin(String path)
        {
            Trace.Write(" - - Compiling " + Path.GetFileName(path) + " . ");
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

            var pluginType = results.CompiledAssembly.GetTypes().FirstOrDefault(type => typeof(GamePluginBase).IsAssignableFrom(type));

            if (pluginType == null)
            {
                Trace.WriteLine("failed! (interface missing)");
                return;
            }
            // Convert the path URI to a normal path.
            var remotePath = new Uri(results.CompiledAssembly.CodeBase).LocalPath;
            var localPath = Path.Combine(this.sandboxFolder, Path.GetFileName(remotePath));
            File.Copy(remotePath, localPath, true);

            permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, localPath));
            permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, WarcraftIII.HackPath));
            permissionSet.Assert();

            var sandbox = AppDomain.CreateDomain("Script Domain", this.sandboxEvidence, this.appDomainSetup, this.permissionSet);
            sandbox.AssemblyResolve += SandboxDomain_AssemblyResolve;
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            sandbox.SetData("api", new GameAPI());
            //Environment.CurrentDirectory = WarcraftIII.HackPath;
            //sandbox.Load(typeof(GamePluginBase).Assembly.FullName);
            //Environment.CurrentDirectory = WarcraftIII.InstallPath;
            this.plugins.Add((GamePluginBase)sandbox.CreateInstanceFrom(localPath, pluginType.FullName).Unwrap());

            Trace.WriteLine("success!");
        }

        private Assembly CurrentDomain_AssemblyResolve(Object sender, ResolveEventArgs args)
        {
            var path = String.Empty;

            if (args.Name == typeof(WarcraftIII).Assembly.FullName)
            {
                path = Path.Combine(WarcraftIII.HackPath, "SharpCraft.Game.dll");
                if (File.Exists(path))
                    return Assembly.LoadFrom(path);
            }

            path = Path.Combine(this.sandboxFolder, args.Name.Split(',').FirstOrDefault() + ".dll");
            if (File.Exists(path))
                return Assembly.LoadFrom(path);

            MessageBox.Show("Couldn't load assembly (current): " + args.Name);

            return null;
        }

        private Assembly SandboxDomain_AssemblyResolve(Object sender, ResolveEventArgs args)
        {
            MessageBox.Show("Couldn't load assembly (sandbox): " + args.Name);

            return null;
        }

        public void InitializePlugins()
        {
            foreach (var plugin in this.plugins)
            {
                Trace.Write(" - - Initializing \"" + plugin.Name + "\" . . . ");
                plugin.Initialize(new GameAPI());
                Trace.WriteLine("Done!");
            }
        }
    }
}
