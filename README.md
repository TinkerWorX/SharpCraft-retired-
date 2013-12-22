SharpCraft
==========

SharpCraft is a library that helps modding Warcraft III: The Frozen Throne.


Features
========

Currently it's possible to add custom natives which are functions for the internal Warcraft III scripting language JASS. It's also possible to call existing natives to access game functionality from the plugin-side.

APIs
=======

Core API

```csharp
// These events happen outside the Jass virtual-machine and should be used as such. GameStarted isn't when the actual game starts, but when the game engine starts the first time a map is started.
event WarcraftIII.GameStarted;
event WarcraftIII.GameEnded;
event WarcraftIII.MapStarted;
event WarcraftIII.MapEnded;
```

Jass API

```csharp
// These events are safe for doing things that require the Jass virtual-machine, like calling natives, creating units, etc.
event WarcraftIII.Jass.PreConfig;
event WarcraftIII.Jass.PostConfig;
event WarcraftIII.Jass.PreMain;
event WarcraftIII.Jass.PostMain;

// Thses methods are for adding custom natives.
void WarcraftIII.Jass.AddNative(Delegate native);
void WarcraftIII.Jass.AddNative(Delegate native, String name);
void WarcraftIII.Jass.AddNative(Delegate native, String name, String prototype);

// The following method is used to get an existing native.
// The Native type provides a method to turn the native into a Delegate.
// Please note that calling natives outside the JASS virtual-machines thread is unsafe.
Native WarcraftIII.Jass.GetNative(String name);
```

Input API

```csharp
// Gets the coordinates of the mouse on the window.
Point2 WarcraftIII.Input.MouseWindow
// Gets the mouse interface position where x = [0.00 .. 0.80] and y = [0.00 .. 0.60]
Vector2 WarcraftIII.Input.MouseUI;
// Gets the mouse ingame terrain coordinates.
Vector3 WarcraftIII.Input.MouseTerrain;
// Checks whether the mouse is over the UI. This seems to be only the letterbox area from cinematic mode.
Boolean WarcraftIII.Input.IsMouseOverUI;
// Fires when a button is pressed.
event WarcraftIII.Input.MouseButton;
// Fires when scrolling the mouse wheel. 
event WarcraftIII.Input.MouseWheel;
// Fires when hitting a key.
event WarcraftIII.Input.KeyboardKey;
```

Interface API
```csharp
// Gets the current FPS.
Single WarcraftIII.Interface.FPS;
// Fires when a player sends a chat message.
event WarcraftIII.Interface.PlayerChat;
// Blocks all chat, allowing for custom systems.
Boolean WarcraftIII.Interface.BlockChat;

// Emulates a player sending a message.
void WarcraftIII.Interface.GameUI.WriteChatMessage(Int32 sender, String message, ChatRecipients recipients, Single duration);
void WarcraftIII.Interface.GameUI.WriteChatMessage(JassPlayer sender, String message, ChatRecipients recipients, Single duration);

// Writes to various parts of the interface, including the player chat area(ChatMessage), the regular message area(UnitMessage), top center(TopMessage) and the bottom information area(Message).
void WarcraftIII.Interface.GameUI.ChatMessage.WriteLine(String message, SColor color, Single duration);
void WarcraftIII.Interface.GameUI.UnitMessage.WriteLine(String message, SColor color, Single duration);
void WarcraftIII.Interface.GameUI.TopMessage.WriteLine(String message, SColor color, Single duration);
void WarcraftIII.Interface.GameUI.Message.WriteLine(String message, SColor color, Single duration);
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
