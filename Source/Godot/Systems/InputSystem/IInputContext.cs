using Godot;
using System;

public interface IInputContext {
    public void HandleInput(InputEvent @event);
}

public class GameContext : IInputContext {


    public event Action<Vector2> OnMousePositionChanged;

    public void HandleInput(InputEvent @event) {

    }

}

public enum InputContextEnum {
    Game = 0
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