using Godot;
using System;

using Kontur.Components.Character;
using Kontur.Components.Character.States;

public partial class PlayerRootComposition : Node {
	[Export] private CharacterController _controller;

	private InputRouter _input = InputRouter.Instance;


	public override void _Ready() {
		GD.Print(_input + "");
		var inputContext = new PlayerInputContext();
		_input.Initialize([
			inputContext
		]);
		GD.Print(_controller + "controller");
		_controller.InputContext = inputContext;
		var idleState = new IdleState(_controller);
		_controller.Initialize([
			idleState
		]);
	}
}
