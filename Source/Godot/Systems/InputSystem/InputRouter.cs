using Godot;
public partial class InputRouter : SingletonNode<InputRouter> {
    private IActionHandler[] _handlers;
    public int CurrentHandlerIndex { get; private set; }
    public IActionHandler CurrentHandler { get; private set; }
        = new DefaultActionHandler();

    public override void _PhysicsProcess(double delta) {
        CurrentHandler.OnPhysicsProcess();
    }
    public override void _UnhandledInput(InputEvent @event) {
        CurrentHandler.HandleInput(@event);
    }

    public void ChangeContextAt(int index) {
        if (_handlers.TryGetValue(index, out var handler)) {
            CurrentHandler = handler;
            CurrentHandlerIndex = index;
        }
    }



    public void Initialize(IActionHandler[] handlers, int index = 0) {
        _handlers = handlers;
        ChangeContextAt(index);
    }

}
