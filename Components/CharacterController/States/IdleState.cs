using Godot;
namespace Kontur.Components.Character.States;

public partial class CharacterStateIdle(
    CharacterController controller,
    CharacterBody3D body)
    : CharacterMoveState<CharacterStateIdle>(controller, body) {

}
