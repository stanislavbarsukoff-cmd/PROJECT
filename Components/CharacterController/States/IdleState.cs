using Godot;

namespace Kontur.Components.Character.States;

public class IdleState(CharacterController controller)
    : CharacterState(controller, CharacterStateType.Idle) {
    private readonly Vector3 _gravity = controller.Body.GetGravity();

    public override void OnPhysicsProcess(double delta) {
        if (Context.InputContext.HasMovementInput) {
            Context.ChangeState(CharacterStateType.Walk);
            return;
        }
        if (!Body.IsOnFloor()) {
            float deltaTime = (float)delta;
            Vector3 velocity = Body.Velocity;
            velocity += _gravity * deltaTime;
            Body.Velocity = velocity;
            Body.MoveAndSlide();
        }
    }
}
