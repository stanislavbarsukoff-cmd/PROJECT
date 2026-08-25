using Godot;
using System;
namespace Kontur.Components.Character.States;

public class WalkState(CharacterController controller)
    : CharacterState(controller, CharacterStateType.Walk) {
    private const float Speed = 5.0f;
    public override void OnPhysicsProcess(double delta) {
        if (!Context.InputContext.HasMovementInput) {
            Context.ChangeState(CharacterStateType.Idle);
            return;
        }
        MoveWithSpeed(Speed, delta);
    }
}
