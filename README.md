SharpCraft
==========

SharpCraft is a library that helps modding Warcraft III: The Frozen Throne.


Features
========

Currently it's possible to add custom natives which are functions for the internal Warcraft III scripting language JASS. It's also possible to call existing natives to access game functionality from the plugin-side.

Methods
=======
The following methods are for adding new natives.
```csharp
void WarcraftIII.Jass.AddNative(Delegate native);
void WarcraftIII.Jass.AddNative(Delegate native, String name);
void WarcraftIII.Jass.AddNative(Delegate native, String name, String prototype);
```
The following method is used to get an existing native. The ```Native``` type provides a method to turn the native into a ```Delegate```. Please note that calling natives outside the JASS virtual-machines thread is unsafe.

```csharp
Native WarcraftIII.Jass.GetNative(String name);
```

The following methods can be used to perform initialization of systems and features in a plugin.

```csharp
event WarcraftIII.GameStarted;
event WarcraftIII.GameEnded;
event WarcraftIII.MapStarted;
event WarcraftIII.MapEnded;
event WarcraftIII.Jass.OnPreConfig;
event WarcraftIII.Jass.OnPostConfig;
event WarcraftIII.Jass.OnPreMain;
event WarcraftIII.Jass.OnPostMain;
```

The following can be used to detect and react to input.

```csharp
Point2 WarcraftIII.Input.MouseWindow
Vector2 WarcraftIII.Input.MouseUI;
Vector3 WarcraftIII.Input.MouseTerrain;
Boolean WarcraftIII.Input.IsMouseOverUI;
event WarcraftIII.Input.MouseButton;;
event WarcraftIII.Input.MouseWheel;
event WarcraftIII.Input.KeyboardKey;
```

Credits
=======
 * MindWorX - for all initial development of SharpCraft
 * SFilip - for coding and research for our old project [Reinventing the Craft](http://www.wc3c.net/showthread.php?t=109255)
 * PipeDream - for making [Grimoire](http://www.wc3c.net/showthread.php?t=86652) which have been used as reference and help on multiple occasions
 * xttocs - for making [jAPI](http://www.wc3c.net/showthread.php?t=79652) without which this probably wouldn't be possible

[![EasyHook][EasyHook]](http://easyhook.codeplex.com/)

[EasyHook]: http://i3.codeplex.com/Download?ProjectName=easyhook&DownloadId=186759 "Powered by EasyHook!"
