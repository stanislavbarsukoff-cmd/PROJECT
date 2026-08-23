public abstract class CharacterState(
    CharacterController controller, MoveState type)
    : State<CharacterController, MoveState>(controller, type) {
    public abstract void OnPhysicsProcess(double delta);
}