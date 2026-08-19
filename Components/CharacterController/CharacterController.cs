using Godot;

public partial class CharacterController : Node
{
    [Export] private CharacterBody3D _body;
    private StateMachine<ICharacterMoveStateMachine> _stateMachine;


    public override void _Ready()
    {
        if(_body is null)
        {
            _body = GetParent<CharacterBody3D>();
        }

        _stateMachine.Initialize([

        ]);
    }
}
