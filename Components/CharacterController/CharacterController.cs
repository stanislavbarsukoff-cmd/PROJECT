using Godot;

namespace Kontur.Components.Character;

public partial class CharacterController : StateContext<CharacterStateType, CharacterState> {
	[Export] public CharacterBody3D Body { get; private set; }
	public PlayerInputContext InputContext { get; set; }

	public override void _PhysicsProcess(double delta) {
		CurrentState.OnPhysicsProcess(delta);
	}
}
