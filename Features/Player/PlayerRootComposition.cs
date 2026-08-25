using Godot;
using System;

using Kontur.Components.Character;
using Kontur.Components.Character.States;

public partial class PlayerRootComposition : Node {
	[Export] private CharacterController _controller;

	private InputRouter _input = InputRouter.Instance;


	public override void _Ready() {
			if (_controller == null) {
		GD.PrintErr("КРИТИЧЕСКАЯ ОШИБКА: _controller не привязан в инспекторе Godot!");
	}
	if (_input == null) {
		GD.PrintErr("КРИТИЧЕСКАЯ ОШИБКА: InputRouter.Instance вернул null!");
	}
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
