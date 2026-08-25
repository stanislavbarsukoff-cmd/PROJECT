using Godot;

namespace Kontur.Components.Character;

public abstract class CharacterState(
    CharacterController controller, CharacterStateType type)
    : State<CharacterController, CharacterStateType>(controller, type) {
    public CharacterBody3D Body { get; } = controller.Body;
    public abstract void OnPhysicsProcess(double delta);

    protected void MoveWithSpeed(float speed, double delta) {
        Vector3 velocity = Body.Velocity;
        Vector2 inputDir = Context.InputContext.MovementVector;
        Vector3 direction = (Body.Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
        velocity.X = direction.X * speed;
        velocity.Z = direction.Z * speed;
        Body.Velocity = velocity;
        Body.MoveAndSlide();
    }
}