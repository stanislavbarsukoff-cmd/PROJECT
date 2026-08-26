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
        if (Context.InputContext.IsSprinting) {
            Context.ChangeState(CharacterStateType.Sprint);
            return;
        }
        Vector2 inputDir = Context.InputContext.MovementVector;
        Vector3 direction = (Body.Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
        ApplyGravity(delta);
        MoveWithDirection(direction, Speed, Acceleration, delta);
        Body.MoveAndSlide();   
    }
}
