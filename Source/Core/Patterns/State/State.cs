using System;

public abstract class State<TContext, TEnum>(TContext context, TEnum type) : IState
    where TEnum : struct, Enum {
    public TEnum StateType { get; } = type;
    public event Action Entered;
    public event Action Exited;
    protected readonly TContext Context = context;
    public virtual void Enter() {
        Entered?.Invoke();
    }
    public virtual void Exit() {
        Exited?.Invoke();
    }
}
