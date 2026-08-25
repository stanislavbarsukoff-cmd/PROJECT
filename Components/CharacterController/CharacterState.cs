using Godot;

namespace Kontur.Components.Character;

public abstract class CharacterState(
    CharacterController controller, CharacterStateType type)
    : State<CharacterController, CharacterStateType>(controller, type) {
    public CharacterBody3D Body { get; } = controller.Body;
    public abstract void OnPhysicsProcess(double delta);

    private const float Acceleration = 15.0f;
    private const float Deceleration = 20.0f;
    protected void MoveWithSpeed(float targetSpeed, double delta) {
        float deltaTime = (float)delta;
        Vector3 velocity = Body.Velocity;
        Vector2 inputDir = Context.InputContext.MovementVector;
        Vector3 direction = (Body.Transform.Basis * new Vector3(inputDir.X, 0, inputDir.Y)).Normalized();
        float step = deltaTime * (Context.InputContext.HasMovementInput ? Acceleration : Deceleration);
        velocity.X = Mathf.MoveToward(velocity.X, direction.X * targetSpeed, step);
        velocity.Z = Mathf.MoveToward(velocity.Z, direction.Z * targetSpeed, step);
        Body.Velocity = velocity;
        Body.MoveAndSlide();
    }
}