using Godot;
using System;

public partial class Cat3 : Sprite2D
{
	Random random = new Random();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var p = GlobalPosition;
		iisst.cat1top = p.Y - 33;
		if (GlobalPosition.X > -50)
		{
			p.X -= 15;
		}

		else if (GlobalPosition.X < -50)
		{
			int Y = random.Next(30, 601);
			p.Y = Y; p.X = 1111;
			iisst.jishu++;
		}
		iisst.cat3top = p.Y -= 30;
		iisst.cat3button = p.Y += 30;
		iisst.cat3left = p.X -= 45;
		iisst.cat3right = p.X += 45;
		GlobalPosition = p;

	}
}
