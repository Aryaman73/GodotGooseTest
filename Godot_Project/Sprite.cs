using Godot;
using System;

public class Sprite : Godot.Sprite
{

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        // M O V E M E N T

        //(int) is casting it to an integer. KeyList is an enum
        float move = 5;
        if (Input.IsKeyPressed((int)KeyList.W))
        {
            this.Position += new Vector2(0, -move);
        }
        if (Input.IsKeyPressed((int)KeyList.A))
        {
            this.Position += new Vector2(-move, 0);
        }
        if (Input.IsKeyPressed((int)KeyList.S))
        {
            this.Position += new Vector2(0, move);
        }
        if (Input.IsKeyPressed((int)KeyList.D))
        {
            this.Position += new Vector2(move, 0);
        }

        float pi = 3.14159F;
        Godot.Sprite baby = this.GetNode<Godot.Sprite>("Baby");
        if (Input.IsActionJustPressed("rotate")) //"Rotate" is an action set in Input Map (Project -> P. Settings)
        {
            baby.GlobalRotation += pi;
        }

    }
}
