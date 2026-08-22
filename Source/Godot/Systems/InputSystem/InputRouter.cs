using Godot;
public partial class InputRouter : Node {
    private IActionHandler[] _handlers;
    public int CurrentHandlerIndex { get; private set; }
    public IActionHandler CurrentHandler { get; private set; }
        = new DefaultActionHandler();

    public override void _UnhandledInput(InputEvent @event) {
        CurrentHandler.HandleInput(@event);
    }

    private void Initialize(IActionHandler[] handlers, int index = 0) {
        _handlers = handlers;
        ChangeContextAt(index);
    }

    public void ChangeContextAt(int index) {
        if (_handlers.TryGetValue(index, out var handler)) {
            CurrentHandler = handler;
            CurrentHandlerIndex = index;
        }
    }

}
