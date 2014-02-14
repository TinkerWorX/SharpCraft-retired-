using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Windows;
using Mono.CSharp;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.SharpCraft.Blizzard.GameModule.APIs;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;
using TinkerWorX.Utilities;
using Assembly = System.Reflection.Assembly;

namespace TinkerWorX.SharpCraft
{
    internal static class PluginSystem
    {
        private static String rootFolder;

        private static String pluginsFolder;

        private static String sandboxFolder;

        private static List<PluginPackage> packages = new List<PluginPackage>();

        private static List<String> assemblyPaths = new List<String>();

        private static List<SafePluginBase> safePlugins = new List<SafePluginBase>();

        private static List<FullPluginBase> fullPlugins = new List<FullPluginBase>();

        private static AppDomain fullDomain;

        private static AppDomain safeDomain;

        public static event Action Ready;

        public static Boolean IsReady { get; private set; }

        public static void Initialize(String context, String folder)
        {
            try
            {
                Trace.Write("Preparing folders . . . ");
                PrepareFolders(folder);
                Trace.WriteLine("done!");

                Trace.WriteLine("Loading packages . . .");
                Trace.Indent();
                LoadPackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Checking references . . .");
                Trace.Indent();
                CheckReferences();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Sorting packages . . .");
                Trace.Indent();
                SortPackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Preparing packages . . .");
                Trace.Indent();
                PreparePackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Preparing sandbox . . .");
                Trace.Indent();
                PrepareSandbox();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Initializing packages . . .");
                Trace.Indent();
                InitializePackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Initializing events . . .");
                Trace.Indent();
                InitializeEvents();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                PluginSystem.OnReady();
            }
            catch (CircularReferenceException)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    "There was a circular reference issue with the plugins." + Environment.NewLine +
                    "Aborting execution!",
                    typeof(PluginSystem) + ".Initialize()", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    typeof(PluginSystem) + ".Initialize()", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        private static void OnReady()
        {
            if (PluginSystem.Ready != null)
                PluginSystem.Ready();
        }

        private static void PrepareFolders(String folder)
        {
            rootFolder = folder;

            pluginsFolder = Path.Combine(rootFolder, "plugins");
            if (!Directory.Exists(pluginsFolder))
                Directory.CreateDirectory(pluginsFolder);

            // Clear out any previous binaries.
            sandboxFolder = Path.Combine(rootFolder, "sandbox");
            if (Directory.Exists(sandboxFolder))
                Directory.Delete(sandboxFolder, true);
            var dir = Directory.CreateDirectory(sandboxFolder);
            dir.Attributes |= FileAttributes.Hidden;
        }

        private static void LoadPackages()
        {
            foreach (var file in Directory.GetFiles(pluginsFolder))
            {
                if (!file.ToLower().EndsWith(".zip"))
                    continue;

                try
                {
                    packages.Add(PluginPackage.FromArchive(file));
                    Trace.WriteLine("Loading archive '" + Path.GetFileName(file) + "'.");
                }
                catch (FileNotFoundException e)
                {
                    Trace.WriteLine("Error in: '" + Path.GetFileName(file) + "': '" + e.FileName + "' is missing from the archive.");
                }
                catch (Exception e)
                {
                    Trace.WriteLine("Error in: '" + Path.GetFileName(file) + "': " + e);
                }
            }

            foreach (var directory in Directory.GetDirectories(pluginsFolder))
            {
                if (!directory.ToLower().EndsWith(".zip"))
                    continue;

                try
                {
                    packages.Add(PluginPackage.FromDirectory(directory));
                    Trace.WriteLine("Loading directory '" + Path.GetFileName(directory) + "'.");
                }
                catch (FileNotFoundException e)
                {
                    Trace.WriteLine("Error in: '" + Path.GetFileName(directory) + "': '" + e.FileName + "' is missing from the directory.");
                }
                catch (Exception e)
                {
                    Trace.WriteLine("Error in: '" + Path.GetFileName(directory) + "': " + e);
                }
            }
        }

        private static void CheckReferences()
        {
            var invalid = new List<PluginPackage>();
            foreach (var package in packages)
            {
                foreach (var reference in package.References)
                {
                    var referencePackage = packages.FirstOrDefault(p => p.Id == reference.Id);
                    if (referencePackage == null)
                    {
                        Trace.WriteLine("'" + package.Name + "' is missing reference '" + reference.Id + "'!");
                        invalid.Add(package);
                        continue;
                    }
                    if (referencePackage.Version != reference.Version)
                    {
                        Trace.WriteLine("'" + package.Name + "' references '" + reference.Id + "' version " + reference.Version + " but only version " + referencePackage.Version + " is available!");
                        invalid.Add(package);
                        continue;
                    }
                }
            }
            foreach (var package in invalid)
                packages.Remove(package);

            // Keep checking until we have no more missing references.
            if (invalid.Count > 0)
                CheckReferences();
        }

        private static void SortPackages()
        {
            var dependencySorter = new DependencySorter<PluginPackage>();
            foreach (var package in packages)
            {
                Trace.WriteLine("Sorting " + package.Name);
                dependencySorter.AddObjects(package);
                var dependencies = new List<PluginPackage>();
                foreach (var reference in package.References)
                {
                    dependencies.Add(packages.First(p => p.Id == reference.Id));
                }
                if (dependencies.Count > 0)
                    dependencySorter.SetDependencies(package, dependencies.ToArray());
            }
            packages = dependencySorter.Sort().ToList();
        }

        private static void PrepareSandbox()
        {
            // Prepare the safe domain.
            var appDomainSetup = new AppDomainSetup()
            {
                ApplicationName = "SharpCraft Scripting Application",
                ApplicationBase = rootFolder,
                DynamicBase = rootFolder
            };

            var safeEvidence = new Evidence();
            safeEvidence.AddHostEvidence(new Zone(SecurityZone.Untrusted));

            // We get a standard sandbox permission set.
            var safePermissionSet = SecurityManager.GetStandardSandbox(safeEvidence);

            // Add global Execution permission to run the assembly.
            safePermissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            safePermissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.UnmanagedCode)); // Needed for the API's to work. Might ruin the whole point of the sandbox though.

            // The script assemblies needs Read and PathDiscovery access.
            foreach (var assembly in assemblyPaths)
                safePermissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery, assembly));
            //safePermissionSet.Assert();

            safeDomain = AppDomain.CreateDomain("SharpCraft Scripting Domain", safeEvidence, appDomainSetup, safePermissionSet);

            // Prepare the full domain.
            fullDomain = AppDomain.CurrentDomain;
            fullDomain.AssemblyResolve += (Object sender, ResolveEventArgs args) =>
            {
                // Convert name to filename
                var file = args.Name.Split(',').First().ToLower() + ".dll";

                // Search root directory
                if (File.Exists(Path.Combine(rootFolder, file)))
                    return Assembly.LoadFrom(Path.Combine(rootFolder, file));

                // Search plugins directory
                if (File.Exists(Path.Combine(Path.Combine(rootFolder, "plugins"), file)))
                    return Assembly.LoadFrom(Path.Combine(Path.Combine(rootFolder, "plugins"), file));

                if (args.Name == "System" || args.Name == "System.Core" || args.Name == "System.Xml" || args.Name == "Microsoft.CSharp")
                    return null;

                //MessageBox.Show("Couldn't load assembly (FullDomain): " + args.Name);

                return null;
            };
        }

        private static void PreparePackages()
        {
            foreach (var package in packages)
            {
                Trace.WriteLine("Preparing " + package.Name);
                foreach (var packageFile in package.Files)
                {
                    var name = package.Id + "-" + packageFile.Name;

                    // Fix invalid characters.
                    foreach (var c in Path.GetInvalidPathChars())
                    {
                        name = name.Replace(c, '-');
                    }
                    var path = Path.Combine(sandboxFolder, name + ".dll");
                    assemblyPaths.Add(path);
                    using (var stream = File.Open(path, FileMode.CreateNew, FileAccess.Write, FileShare.Write))
                    using (var writer = new BinaryWriter(stream))
                    {
                        writer.Write(packageFile.Data);
                    }
                }
            }
        }

        private static void InitializePackages()
        {
            foreach (var package in packages)
            {
                switch (package.Type)
                {
                    case PluginPackageType.Full: Trace.WriteLine("Full initialize of " + package.Name); break;
                    case PluginPackageType.Safe: Trace.WriteLine("Safe initialize of " + package.Name); break;
                }
                Trace.Indent();
                foreach (var packageFile in package.Files)
                {
                    var name = package.Id + "-" + packageFile.Name;
                    Trace.Write("Loading " + packageFile.Name);

                    // Fix invalid characters.
                    foreach (var c in Path.GetInvalidPathChars())
                    {
                        name = name.Replace(c, '-');
                    }

                    var path = Path.Combine(sandboxFolder, name + ".dll");

                    try
                    {
                        var assembly = Assembly.LoadFrom(path);
                        Trace.WriteLine(" . loaded!");
                        Trace.Indent();
                        foreach (var type in assembly.GetTypes())
                        {
                            if (typeof(FullPluginBase).IsAssignableFrom(type))
                            {
                                if (package.Type != PluginPackageType.Full)
                                    continue;
                                Trace.WriteLine("Initializing " + type.Name + " as full plugin!");
                                var plugin = (FullPluginBase)fullDomain.CreateInstanceFrom(path, type.FullName).Unwrap();
                                fullPlugins.Add(plugin);
                                Trace.Indent();
                                plugin.Initialize();
                                plugin.Input = new InputAPI();
                                plugin.Interface = new InterfaceAPI();
                                plugin.Jass = new JassAPI();
                                plugin.Natives = new NativesAPI();
                                Trace.Unindent();
                            }
                            else if (typeof(SafePluginBase).IsAssignableFrom(type))
                            {
                                Trace.WriteLine("Initializing " + type.Name + " as safe plugin!");
                                var plugin = (SafePluginBase)safeDomain.CreateInstanceFrom(path, type.FullName).Unwrap();
                                safePlugins.Add(plugin);
                                Trace.Indent();
                                plugin.Initialize();
                                plugin.Input = new InputAPI();
                                plugin.Interface = new InterfaceAPI();
                                plugin.Jass = new JassAPI();
                                plugin.Natives = new NativesAPI();
                                Trace.Unindent();
                            }
                        }
                        Trace.Unindent();

                    }
                    catch (BadImageFormatException)
                    {
                        Trace.WriteLine(" . invalid assembly!");
                    }
                }
                Trace.Unindent();
            }
        }

        private static void InitializeEvents()
        {
            try
            {
                GameHack.Ready += () =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnGameReady();
                    foreach (var plugin in fullPlugins)
                        plugin.OnGameReady();
                };

                JassMachine.ScriptLoad += (String script) =>
                {
                    if (String.IsNullOrEmpty(script))
                        ClearMapScriptCode();
                    else
                        LoadMapScriptCode(script);
                };

                Input.MouseClick += (MouseButton button, MouseButtonState state, Point2 point) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnMouseClick(button, state, point);
                    if (mapPlugin != null)
                        mapPlugin.OnMouseClick(button, state, point);
                };

                Input.MouseWheel += (Int32 delta) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnMouseWheel(delta);
                    if (mapPlugin != null)
                        mapPlugin.OnMouseWheel(delta);
                };

                Input.KeyboardKey += (Int32 key, Char keyChar, KeyboardKeyState state) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnKeyboardKey(key, keyChar, state);
                    if (mapPlugin != null)
                        mapPlugin.OnKeyboardKey(key, keyChar, state);
                };

                Input.PlayerChat += (Int32 sender, String message, ChatRecipients recipients) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnPlayerChat(sender, message, recipients);
                    if (mapPlugin != null)
                        mapPlugin.OnPlayerChat(sender, message, recipients);
                };

                JassMachine.PreConfig += () =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnPreConfig(!Game.IsInMap);
                };

                JassMachine.PostConfig += () =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnPostConfig(!Game.IsInMap);
                    if (mapPlugin != null)
                        mapPlugin.Config(!Game.IsInMap);
                };

                JassMachine.PreMain += () =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnPreMain();
                };

                JassMachine.PostMain += () =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.OnPostMain();
                    if (mapPlugin != null)
                        mapPlugin.Main();
                };

                Natives.Add(new Natives.CheatPrototype((JassStringArg cheat) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.CheatCallback(cheat);
                    foreach (var plugin in fullPlugins)
                        plugin.CheatCallback(cheat);
                    if (mapPlugin != null)
                        mapPlugin.CheatCallback(cheat);

                    Natives.Cheat(cheat);
                }), "Cheat");
                Natives.Add(new Natives.CreateUnitPrototype((JassPlayer player, JassObjectId id, JassRealArg x, JassRealArg y, JassRealArg facing) =>
                {
                    var unit = Natives.CreateUnit(player, id, x, y, facing);

                    foreach (var plugin in safePlugins)
                        plugin.CreateUnitCallback(unit, player, id, x, y, facing);
                    foreach (var plugin in fullPlugins)
                        plugin.CreateUnitCallback(unit, player, id, x, y, facing);
                    if (mapPlugin != null)
                        mapPlugin.CreateUnitCallback(unit, player, id, x, y, facing);

                    return unit;
                }), "CreateUnit");
                Natives.Add(new Natives.CreateUnitByNamePrototype((JassPlayer player, JassStringArg name, JassRealArg x, JassRealArg y, JassRealArg facing) =>
                {
                    var unit = Natives.CreateUnitByName(player, name, x, y, facing);

                    foreach (var plugin in safePlugins)
                        plugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), x, y, facing);
                    foreach (var plugin in fullPlugins)
                        plugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), x, y, facing);
                    if (mapPlugin != null)
                        mapPlugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), x, y, facing);

                    return unit;
                }), "CreateUnitByName");
                Natives.Add(new Natives.CreateUnitAtLocPrototype((JassPlayer player, JassObjectId id, JassLocation location, JassRealArg facing) =>
                {
                    var unit = Natives.CreateUnitAtLoc(player, id, location, facing);

                    foreach (var plugin in safePlugins)
                        plugin.CreateUnitCallback(unit, player, id, Natives.GetLocationX(location), Natives.GetLocationY(location), facing);
                    foreach (var plugin in fullPlugins)
                        plugin.CreateUnitCallback(unit, player, id, Natives.GetLocationX(location), Natives.GetLocationY(location), facing);
                    if (mapPlugin != null)
                        mapPlugin.CreateUnitCallback(unit, player, id, Natives.GetLocationX(location), Natives.GetLocationY(location), facing);

                    return unit;
                }), "CreateUnitAtLoc");
                Natives.Add(new Natives.CreateUnitAtLocByNamePrototype((JassPlayer player, JassStringArg name, JassLocation location, JassRealArg facing) =>
                {
                    var unit = Natives.CreateUnitAtLocByName(player, name, location, facing);

                    foreach (var plugin in safePlugins)
                        plugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), Natives.GetLocationX(location), Natives.GetLocationY(location), facing);
                    foreach (var plugin in fullPlugins)
                        plugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), Natives.GetLocationX(location), Natives.GetLocationY(location), facing);
                    if (mapPlugin != null)
                        mapPlugin.CreateUnitCallback(unit, player, Natives.GetUnitTypeId(unit), Natives.GetLocationX(location), Natives.GetLocationY(location), facing);

                    return unit;
                }), "CreateUnitAtLocByName");
                Natives.Add(new Natives.CreateCorpsePrototype(
                (JassPlayer player, JassObjectId id, JassRealArg x, JassRealArg y, JassRealArg facing) =>
                {
                    var unit = Natives.CreateUnit(player, id, x, y, facing);

                    foreach (var plugin in safePlugins)
                        plugin.CreateCorpseCallback(unit, player, id, x, y, facing);
                    foreach (var plugin in fullPlugins)
                        plugin.CreateCorpseCallback(unit, player, id, x, y, facing);
                    if (mapPlugin != null)
                        mapPlugin.CreateCorpseCallback(unit, player, id, x, y, facing);

                    return unit;
                }), "CreateCorpse");
                Natives.Add(new Natives.RemoveUnitPrototype((JassUnit unit) =>
                {
                    foreach (var plugin in safePlugins)
                        plugin.RemoveUnitCallback(unit);
                    foreach (var plugin in fullPlugins)
                        plugin.RemoveUnitCallback(unit);
                    if (mapPlugin != null)
                        mapPlugin.RemoveUnitCallback(unit);

                    Natives.RemoveUnit(unit);
                }), "RemoveUnit");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }

        private static CompilerSettings mapCompilerSettings;
        private static ReportPrinter mapReportPrinter;
        private static CompilerContext mapCompilerContext;
        private static Evaluator mapEvaluator;
        private static MapScriptBase mapPlugin;

        private static void SetupMapScriptEngine()
        {
            mapCompilerSettings = new CompilerSettings();
            mapCompilerSettings.AssemblyReferences.Add("System.dll");
            mapCompilerSettings.AssemblyReferences.Add("System.Core.dll");
            mapCompilerSettings.AssemblyReferences.Add(typeof(MessageBox).Assembly.CodeBase); // PresentationFramework.dll
            mapCompilerSettings.AssemblyReferences.Add(Path.Combine(rootFolder, "Windows.dll"));
            mapCompilerSettings.AssemblyReferences.Add(Path.Combine(rootFolder, "Utilities.dll"));
            mapCompilerSettings.AssemblyReferences.Add(Path.Combine(rootFolder, "SharpCraft.dll"));
            foreach (var assemblyPath in assemblyPaths)
            {
                mapCompilerSettings.AssemblyReferences.Add(assemblyPath);
            }
            mapReportPrinter = new TraceReportPrinter();

            mapCompilerContext = new CompilerContext(mapCompilerSettings, mapReportPrinter);
            mapEvaluator = new Evaluator(mapCompilerContext);
        }

        private static void ClearMapScriptCode()
        {
            mapCompilerSettings = null;
            mapReportPrinter = null;
            mapCompilerContext = null;
            mapEvaluator = null;
        }

        private static void LoadMapScriptCode(String script)
        {
            SetupMapScriptEngine();
            mapEvaluator.Compile(script);

            try
            {
                var type = (Type)mapEvaluator.Evaluate("typeof(MapScript)");

                if (type == null)
                    throw new MapScriptException("MapScript type missing");

                if (!typeof(MapScriptBase).IsAssignableFrom(type))
                    throw new MapScriptException("MapScript does not inherit from " + typeof(MapScriptBase).Name);

                mapPlugin = (MapScriptBase)Activator.CreateInstance(type);
                mapPlugin.Input = new InputAPI();
                mapPlugin.Interface = new InterfaceAPI();
                mapPlugin.Jass = new JassAPI();
                mapPlugin.Natives = new NativesAPI();
            }
            catch (MapScriptException e)
            {
                Trace.WriteLine("MapScript error: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Trace.WriteLine("MapScript error: " + e.Message);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
    }

    internal class TraceReportPrinter : ReportPrinter
    {
        public override void Print(AbstractMessage msg, Boolean showFullPath)
        {
            if (msg.IsWarning)
                Trace.WriteLine("MapScript warning: " + msg.Text);
            else
                Trace.WriteLine("MapScript error: " + msg.Text);

            base.Print(msg, showFullPath);
        }
    }

    internal class MapScriptException : Exception
    {
        public MapScriptException(String message) : base(message) { }
    }
}
