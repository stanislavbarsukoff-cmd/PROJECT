using Godot;
using Kontur.Components.Character;
using System;

public partial class SprintState(CharacterController controller)
	: CharacterState(controller, CharacterStateType.Sprint) {
	private const float SprintSpeed = 10f;
    public override void OnPhysicsProcess(double delta) {
        if (!Context.InputContext.HasMovementInput) {
            Context.ChangeState(CharacterStateType.Idle);
            return;
        }
        if (!Context.InputContext.IsSprinting) {
            Context.ChangeState(CharacterStateType.Walk);
            return;
        }
        Vector2 inputDir = Context.InputContext.MovementVector;
        Vector3 direction = (Body.Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
        ApplyGravity(delta);
        MoveWithDirection(direction, SprintSpeed, Acceleration, delta);
        Body.MoveAndSlide();
    }
}
