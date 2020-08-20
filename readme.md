# Godot C# Test Game:

Tutorial Followed: https://www.youtube.com/watch?v=Ej2p_TPGCDE
Tutorial by Abdullah Aghazadah

Godot + C#

# Notes: 
 - Godot is based around the concept of Nodes
 - "+" -> Sprite -> Texture (for Images)
 - res:// is the root of the project
 - .tscn is the extension for a "scene"
 - To add activities/actions to a Sprite, you attach a "Script" (written in C#)
 - .cs is for C# files
 - Note that y-axis is reversed in Godot

 - Hierarchy: Scene > Parent Nodes > Child Nodes
 - A child node reacts to whatever action is done in a parent node
 - The transform/position values of the child are relative to the parent, not to the origin

 - GetNode<>(path) -> path behaves like paths in cmd, i.e. .. = parent, ./childnode etc.
 - GetParent<>() -> gets you the parent node directly
 - Position -> Placing Node, _Ready() -> Called when scene is first run, _Process() -> called every frame

 - Use Project -> Project Settings -> Input Map to set actions connected to inputs
 - In Script Files, use action-based functions instead of key-based functions