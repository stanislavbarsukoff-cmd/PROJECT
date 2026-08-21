using Godot;
public partial class FirstPersonCamera : Camera3D {
    [Export] public float Sensitivity { get; set; }

    [Export] private CharacterBody3D _body;

    private StateMachine<IFirstPersonCameraStateMachine> _stateMachine;

    public override void _Ready() {
        _stateMachine = new StateMachine<IFirstPersonCameraStateMachine>();
        _stateMachine.Initialize([
           new FirstPersonCameraLookState(this, _body)
        ]);
        _stateMachine.SetState<FirstPersonCameraLookState>();
    }

}
