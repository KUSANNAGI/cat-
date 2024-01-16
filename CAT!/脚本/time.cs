using Godot;
using System;

public partial class time : RichTextLabel
{
	public DateTime start =  DateTime.Now;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		int temp;
		int second;
		var p = DateTime.Now;


		second = p.Second - start.Second;

		if (p.Minute != start.Minute)
		{
			temp = p.Minute - start.Minute;
			second += temp * 60;
		}
		this.Text = ("the time have run normally:"+second);
	}
}
