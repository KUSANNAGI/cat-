using Godot;
using System;

public partial class Dog1 : Sprite2D
{
	Random random = new Random();
	DateTime start = DateTime.Now; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		DateTime now = DateTime.Now;bool contor;
        if (now.Minute <= start.Minute)
        {
			contor = true;
        }
		if (now.Minute%2!=0)
        {
			contor = true;
        }
        else
        {
			contor = false;
        }
        if (contor)
        {
			var p = GlobalPosition;
			if (GlobalPosition.X > -50)
			{
				p.X -= 3;
			}
			else if (GlobalPosition.X < -50)
			{
				int Y = random.Next(30, 601);
				p.Y = Y; p.X = 1111;
			}
			iisst.dogtop = p.Y -= 16;
			iisst.dogbutton = p.Y += 16;
			iisst.dogleft = p.X -= 16;
			iisst.dogright = p.X += 16;
			GlobalPosition = p;
		}
	}
}
