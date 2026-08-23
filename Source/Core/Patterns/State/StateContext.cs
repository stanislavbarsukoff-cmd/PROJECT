using Godot;
using System;
using System.Runtime.CompilerServices;
public partial class StateContext<TEnum, TState> : Node
    where TEnum : struct, Enum
    where TState : class, IState {
    public TEnum CurrentStateType { get; private set; }
    public TState CurrentState { get; private set; }

    private TState[] _states;

    public void Initialize(TState[] states, int index = 0) {
        _states = states;
        ChangeStateAt(index);
    }
    public bool ChangeStateAt(int index) {
        if (_states.TryGetValue(index, out var state)) {
            CurrentState?.Exit();
            (CurrentState = _states[index])?.Enter();
            return true;
        }
        return false;
    }
    public void ChangeState(TEnum nextState) {
        int index = Unsafe.BitCast<TEnum, int>(nextState);
        if (ChangeStateAt(index)) {
            CurrentStateType = nextState;
        }
    }

}
