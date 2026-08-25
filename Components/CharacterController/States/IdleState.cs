using Godot;

namespace Kontur.Components.Character.States;

public class IdleState(
    CharacterController controller, CharacterBody3D body)
    : CharacterState(controller, body, CharacterStateType.Idle) {

    private const float Friction = 20.0f;
    public override void OnPhysicsProcess(double delta) {
        float deltaTime = (float)delta;
        Vector3 velocity = Body.Velocity;
        if(!Body.IsOnFloor()) {
            velocity += Body.GetGravity() * deltaTime;
        }
        else {
            float step = deltaTime * Friction;
            velocity.X = Mathf.MoveToward(velocity.X, default, step);
            velocity.Z = Mathf.MoveToward(velocity.Z, default, step);
        }
        Body.Velocity = velocity;
        Body.MoveAndSlide();
    }
}
