using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using TinkerWorX.SharpCraft.Utilities;
using Assembly = System.Reflection.Assembly;

namespace TinkerWorX.SharpCraft
{
    internal static class PluginSystem
    {
        private static String rootFolder;

        private static String packFolder;

        private static String tempFolder;

        private static List<PluginPackage> packages = new List<PluginPackage>();

        private static List<String> assemblyPaths = new List<String>();

        private static List<PluginBase> plugins = new List<PluginBase>();

        public static void LoadPlugins(String folder)
        {
            try
            {
                Trace.Write("Preparing folders . . . ");
                Trace.Indent();
                PrepareFolders(folder);
                Trace.Unindent();
                Trace.WriteLine("done!");

                Trace.WriteLine("Loading packages . . .");
                Trace.Indent();
                LoadPackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Checking references . . .");
                Trace.Indent();
                CheckReferences();
                SortPackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");

                Trace.WriteLine("Extracting packages . . .");
                Trace.Indent();
                ExtractPackages();
                InitializePackages();
                Trace.Unindent();
                Trace.WriteLine(" - Done!");
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

        public static void Initialize(PluginContext context)
        {
            foreach (var plugin in plugins)
            {
                plugin.Initialize(context);
            }
        }

        public static void OnGameLoad(PluginContext context)
        {
            foreach (var plugin in plugins)
            {
                plugin.OnGameLoad(context);
            }
        }

        private static void PrepareFolders(String folder)
        {
            rootFolder = folder;

            packFolder = Path.Combine(rootFolder, "plugins");
            if (!Directory.Exists(packFolder))
                Directory.CreateDirectory(packFolder);

            // Clear out any previous binaries.
            tempFolder = Path.Combine(rootFolder, "temp");
            if (Directory.Exists(tempFolder))
                Directory.Delete(tempFolder, true);
            var dir = Directory.CreateDirectory(tempFolder);
            dir.Attributes |= FileAttributes.Hidden;
        }

        private static void LoadPackages()
        {
            foreach (var file in Directory.GetFiles(packFolder))
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

            foreach (var directory in Directory.GetDirectories(packFolder))
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

        private static void ExtractPackages()
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
                    var path = Path.Combine(tempFolder, name + ".dll");
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
                Trace.WriteLine("Initializing " + package.Name + "!");
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

                    var path = Path.Combine(tempFolder, name + ".dll");

                    try
                    {
                        var assembly = Assembly.LoadFrom(path);
                        Trace.WriteLine(" . done!");
                        Trace.Indent();
                        foreach (var type in assembly.GetTypes())
                        {
                            if (typeof(PluginBase).IsAssignableFrom(type))
                                plugins.Add((PluginBase)Activator.CreateInstance(type));
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
    }
}
