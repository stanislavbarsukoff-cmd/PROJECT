using Godot;
public class DefaultActionHandler : IActionHandler {
    public void HandleInput(InputEvent @event) {
        GD.Print("gdscript");
    }
}
