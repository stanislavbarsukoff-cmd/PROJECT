using Godot;
using System;

using Kontur.Components.Character;
using Kontur.Components.Character.States;

public partial class PlayerRootComposition : Node {
	[Export] private CharacterController _controller;
	private InputRouter _input;


	public override void _Ready() {
		_input = InputRouter.Instance;
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
