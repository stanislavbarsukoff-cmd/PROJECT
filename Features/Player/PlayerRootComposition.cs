using Godot;
using System;

using Kontur.Components.Character;
using Kontur.Components.Character.States;

public partial class PlayerRootComposition : Node {
    [Export] private CharacterController _controller;

    private InputRouter _input = InputRouter.Instance;


    public override void _Ready() {
        var inputContext = new PlayerInputContext();
        _input.




        var characterBody = _controller.Body;


        var idleState = new IdleState(_controller, characterBody);

        _controller.Initialize([
            idleState
        ]);
    }
}
