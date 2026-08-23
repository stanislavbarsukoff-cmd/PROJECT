using Godot;


public enum MoveState {
	idle = 0
}

public partial class CharacterController : StateContext<MoveState, CharacterState> {
	[Export] public CharacterBody3D Body { get; private set; }

    public override void _PhysicsProcess(double delta) {
        CurrentState.
    }
}
