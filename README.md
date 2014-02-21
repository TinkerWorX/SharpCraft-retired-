SharpCraft
==========

SharpCraft is a library that helps modding Warcraft III: The Frozen Throne.


Features
========

Currently it's possible to add custom natives which are functions for the internal Warcraft III scripting language JASS. It's also possible to call existing natives to access game functionality from the plugin-side.

APIs
=======
SharpCraft comes with three different base classes to use and a plugin system.

```csharp
abstract class FullPluginBase; // This class is for plugins that need full access, which means file writing and more.
abstract class SafePluginBase; // This class is for plugins that only need safe access.
abstract class MapScriptBase;  // This class is for internal war3map.cs scripts. It is similar to SafePluginBase.
```

All classes have access to the following members.
```csharp
interface IInputFullAPI/IInputSafeAPI Input; // Keyboard, mouse, etc.
interface IInterfaceFullAPI/IInterfaceSafeAPI Interface; // FPS
interface IJassFullAPI/IJassSafeAPI Jass; // Config/Main events.
interface INativesFullAPI/INativesSafeAPI Natives; // Calling natives, adding natives, etc.
```

Credits
=======
 * MindWorX - for all initial development of SharpCraft
 * SFilip - for coding and research for our old project [Reinventing the Craft](http://www.wc3c.net/showthread.php?t=109255)
 * PipeDream - for making [Grimoire](http://www.wc3c.net/showthread.php?t=86652) which have been used as reference and help on multiple occasions
 * xttocs - for making [jAPI](http://www.wc3c.net/showthread.php?t=79652) without which this probably wouldn't be possible
 * TriggerHappy - for contributions to SharpCraft

[![EasyHook][EasyHook]](http://easyhook.codeplex.com/)

[EasyHook]: http://i3.codeplex.com/Download?ProjectName=easyhook&DownloadId=186759 "Powered by EasyHook!"
