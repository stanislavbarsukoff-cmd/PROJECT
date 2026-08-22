using Godot;
using System;

public partial class PlayerRootComposition : Node {
    [Export] private CharacterController _controller;

    private InputRouter _input = InputRouter.Instance;


    public override void _Ready() {
        var characterBody = _controller.Body;


        var playerIdleState = new CharacterStateIdle(_controller, characterBody);

        _controller.
    }
}
