using Godot;
using System;

public partial class playermovement : Area2D
{
	[Export]
	private int _playerSpeed { get; set; } = 400;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
