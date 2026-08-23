namespace Kontur.Components.Character.States;

public class IdleState(
    CharacterController controller)
    : CharacterState(controller, MoveState.Idle) {
    public override void OnPhysicsProcess(double delta) {
        
    }
}
