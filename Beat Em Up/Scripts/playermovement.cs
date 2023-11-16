using Godot;
using System;

public partial class PlayerMovement : CharacterBody3D
{
	[Export]
	private int _playerSpeed { get; set; } = 10;
	
	[Export]
	private int _fallAcceleration { get; set; } = 75;
	
	private Vector3 _targetVelocity = Vector3.Zero;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		Vector3 movementDirection = Vector3.Zero;


		if (Input.IsActionPressed("move_right")) { movementDirection.X += 1.0f; }
		if (Input.IsActionPressed("move_left")) { movementDirection.X -= 1.0f; }
		if (Input.IsActionPressed("move_up")) { movementDirection.Z -= 1.0f; }
		if (Input.IsActionPressed("move_down")) { movementDirection.Z += 1.0f; }

		if (movementDirection != Vector3.Zero)
		{
			movementDirection = movementDirection.Normalized();
		}

		_targetVelocity.X = movementDirection.X * _playerSpeed;
		_targetVelocity.Z = movementDirection.Z * _playerSpeed;

		Velocity = _targetVelocity;
		MoveAndSlide();
	}
}
