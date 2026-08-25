using Godot;

public partial class PlayerInputContext : IActionHandler {
    private readonly StringName MoveLeft = "move_left";
    private readonly StringName MoveRight = "move_right";
    private readonly StringName MoveForward = "move_forward";
    private readonly StringName MoveBackward = "move_backward";


    public void HandleInput(InputEvent @event) {
        
    }

    public Vector2 GetMovementVector()
        => Input.GetVector(MoveLeft, MoveRight, MoveForward, MoveBackward);
}
