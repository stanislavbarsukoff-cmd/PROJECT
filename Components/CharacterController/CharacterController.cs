using Godot;

public partial class CharacterController : Node {
	[Export] public CharacterBody3D Body { get; private set; }
	private StateMachine<ICharacterMoveStateMachine> _stateMachine;

	public override void _Ready() {
		_stateMachine = new StateMachine<ICharacterMoveStateMachine>();
	}

	public override void _Process(double delta) {
		_stateMachine.CurrentState.Process();
	}

}
