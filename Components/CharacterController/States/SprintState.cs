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
		MoveWithSpeed(SprintSpeed, delta);
    }
}
