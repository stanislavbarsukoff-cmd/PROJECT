using Godot;
using System;

public partial class StateContext<TState, TEnum> : Node
    where TState : class, IState
    where TEnum : struct, Enum {
    private TState[] _states;
    public TState CurrentState { get; private set; }

    public void Initialize(TState[] states, int startStateIndex = 0) {
        _states = states;
        ChangeState(startStateIndex);
    }

    public void ChangeState(int index) {
        if (_states.TryGetValue(index, out var state)) {
            CurrentState?.Exit();
            (CurrentState = _states[index])?.Enter();
        }
    }

}
