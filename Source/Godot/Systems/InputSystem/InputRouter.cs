using Godot;

public partial class InputRouter : Node {
    private IInputHandler[] _handlers;
    public int CurrentIndex { get; private set; }
    public IInputHandler CurrentHandler { get; private set; }

    public override void _Ready() {
        Initialize([

        ]);
    }

    public override void _UnhandledInput(InputEvent @event) {
        CurrentHandler.HandleInput(@event);
    }

    private void Initialize(IInputHandler[] handlers, int startIndex = 0) {
        _handlers = handlers;
        ChangeContextAt(startIndex);
    }

    public void ChangeContextAt(int index) {

#if DEBUG
        if (index)


            CurrentIndex = index;
        CurrentHandler = _handlers[index];
    }

}
