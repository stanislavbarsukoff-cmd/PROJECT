using Godot;

namespace Kontur.Components.Character;

public abstract class CharacterState(
    CharacterController controller, CharacterStateType type)
    : State<CharacterController, CharacterStateType>(controller, type) {
    public CharacterBody3D Body { get; } = controller.Body;
    public abstract void OnPhysicsProcess(double delta);

    private const float Acceleration = 15.0f;
    private const float Deceleration = 20.0f;

    private readonly Vector3 _gravity = controller.Body.GetGravity();
    protected void ApplyGravity(double delta) {
        if (!Body.IsOnFloor()) {
            Vector3 velocity = Body.Velocity;
            velocity += _gravity * (float)delta;
            Body.Velocity = velocity;
        }
    }

    protected void MoveWithDirection(Vector3 direction, float targetSpeed, float currentAcceleration, double delta) {
        float deltaTime = (float)delta;
        Vector3 velocity = Body.Velocity;
        velocity.X = Mathf.MoveToward(velocity.X, direction.X * targetSpeed, currentAcceleration * deltaTime);
        velocity.Z = Mathf.MoveToward(velocity.Z, direction.Z * targetSpeed, currentAcceleration * deltaTime);
        Body.Velocity = velocity;
    }
}
