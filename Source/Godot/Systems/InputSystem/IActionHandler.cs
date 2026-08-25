using Godot;

public interface IActionHandler {
    public void HandleInput(InputEvent @event);
    public void OnPhysicsProcess();
}