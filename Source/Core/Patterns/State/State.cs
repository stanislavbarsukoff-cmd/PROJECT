using System;

public abstract class State<TContext, TEnum>(TContext context, TEnum type) : IState
    where TEnum : struct, Enum {
    protected readonly TContext Context = context;
    public TEnum StateType { get; } = type;
    public virtual void Enter() { }
    public virtual void Exit() { }
}
