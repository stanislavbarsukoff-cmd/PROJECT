using Godot;
using System;

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