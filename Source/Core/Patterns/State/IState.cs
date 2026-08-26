using System;
public interface IState {
    public event Action Entered;
    public event Action Exited;
    public void Enter();
    public void Exit();
}
