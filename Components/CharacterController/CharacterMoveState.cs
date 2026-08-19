using Godot;
public interface ICharacterMoveStateMachine;
public abstract class CharacterMoveState<TState>(
        CharacterController controller,
        CharacterBody3D body
    )
    : State<ICharacterMoveStateMachine, TState>
{
    protected CharacterController _controller = controller;
    protected CharacterBody3D _body = body;
}
