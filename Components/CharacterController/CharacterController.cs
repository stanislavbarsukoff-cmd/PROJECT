using Godot;

public partial class CharacterController : Node
{
    private StateMachine<CharacterMoveState> _stateMachine;


    public override void _Ready()
    {
        _stateMachine.Initialize([

        ]);
    }
}
