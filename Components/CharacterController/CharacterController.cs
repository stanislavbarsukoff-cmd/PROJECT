using Godot;

public partial class CharacterController : Node
{
    private StateMachine<ICharacterMoveStateMachine> _stateMachine;


    public override void _Ready()
    {
        _stateMachine.Initialize([

        ]);
    }
}
