using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using TinkerWorX.SharpCraft.Blizzard.Storm;
using TinkerWorX.SharpCraft.Utilities;

namespace TinkerWorX.SharpCraft
{
    internal static class PluginSystem
    {
        private static String folder;

        private static PluginContext context;

        private static List<IPlugin> plugins = new List<IPlugin>();

        private static List<IMapPlugin> mapPlugins = new List<IMapPlugin>();

        private static Dictionary<String, String> assemblies = new Dictionary<String, String>();

        static PluginSystem() { }

        public static void LoadPlugins(String folder, PluginContext context)
        {
            try
            {
                PluginSystem.folder = folder;
                PluginSystem.context = context;

                Assembly.ReflectionOnlyLoadFrom(Path.Combine(folder, @"..\SharpCraft.dll"));

                var list = new DependencySorter<String>();
                Trace.WriteLine("Locating plugins . . .");
                Trace.Indent();
                var sw = Stopwatch.StartNew();
                foreach (var file in Directory.GetFiles(folder, "*.dll", SearchOption.AllDirectories))
                {
                    try
                    {
                        Trace.WriteLine("File: " + Path.GetFileName(file));
                        Trace.Indent();
                        var assembly = Assembly.ReflectionOnlyLoadFrom(file);
                        foreach (var type in assembly.GetTypes().Where(t => t.Implements<IPlugin>()))
                        {
                            try
                            {
                                Trace.WriteLine("Type: " + type.FullName);
                                assemblies.Add(type.FullName, file);
                                list.AddObjects(type.FullName);
                                Trace.Indent();
                                foreach (var requires in type.GetRequires())
                                {
                                    list.SetDependencies(type.FullName, requires);
                                    Trace.WriteLine("Requires: " + requires);
                                }
                                Trace.Unindent();
                            }
                            catch (Exception e)
                            {
                                Trace.WriteLine("Exception: " + e.Message);
                            }
                        }
                        Trace.Unindent();
                    }
                    catch (ReflectionTypeLoadException e)
                    {
                        Trace.WriteLine("Exception: " + e);
                        Trace.Indent();
                        foreach (var exception in e.LoaderExceptions)
                        {
                            Trace.WriteLine("LoaderException: " + exception);
                        }
                        Trace.Unindent();
                    }
                }
                sw.Stop();
                Trace.WriteLine("Done! (" + sw.Elapsed.TotalMilliseconds.ToString("0.00") + " ms)");
                Trace.Unindent();

                Trace.WriteLine("Loading plugin assemblies and instanciating types. . .");
                Trace.Indent();
                sw.Restart();
                foreach (var s in list.Sort())
                {
                    Trace.WriteLine("Loading assembly '" + Path.GetFileName(assemblies[s]) + "' for type '" + s + "'");
                    plugins.Add((IPlugin)Activator.CreateInstance(assemblies[s], s).Unwrap());
                }
                sw.Stop();
                Trace.WriteLine("Done! (" + sw.Elapsed.TotalMilliseconds.ToString("0.00") + " ms)");
                Trace.Unindent();

                Trace.WriteLine("Initializing plugins . . .");
                Trace.Indent();
                sw.Restart();
                foreach (var plugin in plugins)
                {
                    Trace.WriteLine("Initializing " + plugin.GetType().FullName);
                    Trace.Indent();
                    try
                    {
                        plugin.Initialize(context);
                    }
                    catch (Exception e)
                    {
                        Trace.WriteLine(e);
                    }
                    Trace.Unindent();
                }
                sw.Stop();
                Trace.WriteLine("Done! (" + sw.Elapsed.TotalMilliseconds.ToString("0.00") + " ms)");
                Trace.Unindent();
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

        public static void OnGameLoad()
        {
            try
            {
                Trace.WriteLine("OnGameLoad plugins . . .");
                Trace.Indent();
                var sw = Stopwatch.StartNew();
                foreach (var plugin in plugins)
                {
                    try
                    {
                        plugin.OnGameLoad(context);
                    }
                    catch (Exception e)
                    {
                        Trace.WriteLine("OnGameLoad(" + plugin + "): " + e);
                    }
                }
                sw.Stop();
                Trace.WriteLine("Done! (" + sw.Elapsed.TotalMilliseconds.ToString("0.00") + " ms)");
                Trace.Unindent();
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "Fatal exception!" + Environment.NewLine +
                    exception + Environment.NewLine +
                    "Aborting execution!",
                    typeof(PluginSystem) + ".OnGameLoad()", MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill();
            }
        }

        public static void OnMapStart()
        {
            using (var listfileStream = new StormFileStream(SFile.OpenFileEx(IntPtr.Zero, "(listfile)", 0)))
            using (var listfileReader = new StreamReader(listfileStream))
            {
                Trace.WriteLine("Files");
                var listfile = listfileReader.ReadToEnd();
                var files = listfile.Replace("\r\n", "*").Replace("\r", "*").Replace("\n", "*").Split('*');
                for (var i = 0; i < files.Length - 1; i++)
                {
                    Trace.WriteLine(" * '" + files[i] + "'");
                    if (files[i].EndsWith(".dll"))
                    {
                        using (var pluginStream = new StormFileStream(SFile.OpenFileEx(IntPtr.Zero, files[i], 0)))
                        {
                            var pluginBuffer = new byte[pluginStream.Length];
                            pluginStream.Read(pluginBuffer, 0, pluginBuffer.Length);
                            var pluginAssembly = Assembly.Load(pluginBuffer);
                            foreach (var t in pluginAssembly.GetTypes())
                                if (typeof(IMapPlugin).IsAssignableFrom(t))
                                    mapPlugins.Add((IMapPlugin)Activator.CreateInstance(t));
                        }
                    }
                }
            }

            foreach (var mapPlugin in mapPlugins)
                mapPlugin.OnMapStart();
        }

        public static void OnMapEnd()
        {
            foreach (var mapPlugin in mapPlugins)
                mapPlugin.OnMapEnd();
            mapPlugins.Clear();
        }
    }
}
