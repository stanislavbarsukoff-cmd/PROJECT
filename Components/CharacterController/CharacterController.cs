using Godot;

namespace Kontur.Components.Character;

public partial class CharacterController : StateContext<MoveState, CharacterState> {
	[Export] public CharacterBody3D Body { get; private set; }

	public override void _PhysicsProcess(double delta) {
		CurrentState.OnPhysicsProcess(delta);
	}
}
