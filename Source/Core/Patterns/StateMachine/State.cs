using System;

public abstract class State {
    public abstract int Id { get; }
    public event Action Entered;
    public event Action Exited;
    public virtual void Enter() {
        Entered?.Invoke();
    }
    public virtual void Exit() {
        Exited?.Invoke();
    }
    public virtual void Process() { }

}

public abstract class State<TMarker, TEntity> : State {
    public override int Id => TypeIdRegistry<TMarker>.For<TEntity>.Id;
}
