using Godot;
using System;

public abstract class State
{
    public abstract int Id { get; }

    private virtual void Enter() { }
    private virtual void Exit() { }
    private virtual void Process() { }
}

public abstract class State<TMarker, TEntity> : State
{
    public override int Id => TypeIdRegistry<TMarker>.For<TEntity>.Id;
}