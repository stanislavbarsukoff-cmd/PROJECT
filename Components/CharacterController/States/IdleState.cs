namespace Kontur.Components.Character.States;

public class IdleState(CharacterController controller)
    : CharacterState(controller, CharacterStateType.Idle) {
    public override void OnPhysicsProcess(double delta) {
        ApplyGravity(delta);
        if (Context.InputContext.HasMovementInput) {
            Context.ChangeState(CharacterStateType.Walk);
        }
    }
}
