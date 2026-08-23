using Godot;

namespace Kontur.Components.Character;

public abstract class CharacterState(
    CharacterController controller, CharacterBody3D body, MoveState type)
    : State<CharacterController, MoveState>(controller, type) {
    public CharacterBody3D Body { get; } = body;
    public abstract void OnPhysicsProcess(double delta);
}