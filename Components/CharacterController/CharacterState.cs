using Godot;

namespace Kontur.Components.Character;

public abstract class CharacterState(
    CharacterController controller, CharacterStateType type)
    : State<CharacterController, CharacterStateType>(controller, type) {
    public CharacterBody3D Body { get; } = controller.Body;
    public abstract void OnPhysicsProcess(double delta);
}