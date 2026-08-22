using Godot;

public interface IInputHandler {
    public void HandleInput(InputEvent @event);
}


public partial class MyInputManager : Node {
    private IInputContext[] _contexts;
    public int CurrentIndex { get; private set; }
    public IInputContext CurrentContext { get; private set; }

    public override void _Ready() {
        _contexts = [
          new GameContext()
        ];
        ChangeContextAt(0);
    }

    public void ChangeContextAt(int index) {
        CurrentIndex = index;
        CurrentContext = _contexts[index];
    }


    public override void _UnhandledInput(InputEvent @event) {
        CurrentContext.HandleInput(@event);
    }
}