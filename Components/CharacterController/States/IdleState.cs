using Godot;

namespace Kontur.Components.Character.States;

public class IdleState(
    CharacterController controller, CharacterBody3D body)
    : CharacterState(controller, body, MoveState.Idle) {
    public override void OnPhysicsProcess(double delta) {

    }
}
