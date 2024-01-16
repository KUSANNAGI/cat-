using Godot;
using System;

public partial class Mouse1 : Sprite2D
{
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var p = GlobalPosition;
		if (GlobalPosition.X != 30)
        {
			p.X = p.Y = 30; GlobalPosition = p;
		}
		
		if (Input.IsActionJustPressed("ui_up"))
		{
			GD.Print("Cat：up!");

		}
		if (Input.IsActionJustPressed("ui_down"))
		{
			System.Environment.Exit(exitCode: 0);
		}
		if (Input.GetActionStrength("down") == 1)
		{
			p.Y += 15;

		}
        if (Input.GetActionStrength("up") == 1)
        {
			p.Y -= 15;
        }
        if (p.Y < 0)
        {
			p.Y = 20;
        }
        if (p.Y > 600)
        {
			p.Y = 600;
        }
		iisst.mousetop = p.Y -= 25;
		iisst.mousebottom = p.Y += 25;
		iisst.mouseleft = p.X -= 25;
		iisst.mouseright = p.X += 25;
		GlobalPosition = p;
	}
}
