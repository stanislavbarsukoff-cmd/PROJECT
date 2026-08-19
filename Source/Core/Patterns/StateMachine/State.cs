using Godot;

public abstract class State
{
    public abstract int Id { get; }

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Process() { }
}

public abstract class State<TMarker, TEntity> : State
{
    public override int Id => TypeIdRegistry<TMarker>.For<TEntity>.Id;
}

public class BaseStateMachine
{
    public int CurrentStateIndex { get; private set; }
    public State CurrentState => _states[CurrentStateIndex];

    private State[] _states;

    public void Initialize(State[] states)
    {
        if (_states is not null)
        {
            return;
        }
        for (int i = 0; i < states.Length; i++)
        {
            int stateIndex = states[i].Id;
            if (stateIndex == i)
            {
                break;
            }
            (states[stateIndex], states[i]) = (states[i], states[stateIndex]);
            i--;
        }
        _states = states;
        CurrentStateIndex = default;
    }

    public void SetState<TMarker, TEntity>()
    {
        _states[CurrentStateIndex].Exit();
        CurrentStateIndex = TypeIdRegistry<TMarker>.For<TEntity>.Id;
        _states[CurrentStateIndex].Enter();
    }

}
