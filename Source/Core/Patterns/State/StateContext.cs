using Godot;
using System;
using System.Runtime.CompilerServices;
public partial class StateContext<TState, TEnum> : Node
    where TState : class, IState
    where TEnum : struct, Enum {
    private TState[] _states;
    public TState CurrentState { get; private set; }
    public TEnum CurrentStateType { get; private set; }

    public void Initialize(TState[] states, int startIndex = 0) {
        _states = states;
        ChangeStateAt(startIndex);
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
        int index = Unsafe.BitCast<TEnum, byte>(nextState);
        if (ChangeStateAt(index)) {
            CurrentStateType = nextState;
        }
    }

}
