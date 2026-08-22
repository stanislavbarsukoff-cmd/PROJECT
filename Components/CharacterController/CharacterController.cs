using Godot;

public partial class CharacterController : Node {
	[Export] private CharacterBody3D _body;
	private StateMachine<ICharacterMoveStateMachine> _stateMachine;

	public override void _Ready() {
		_stateMachine = new StateMachine<ICharacterMoveStateMachine>();
	}

	public override void _Process(double delta) {
		_stateMachine.CurrentState.Process();
	}
}
