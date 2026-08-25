using Godot;

public partial class PlayerInputContext : IActionHandler {
    private static readonly StringName MoveLeft = "move_left";
    private static readonly StringName MoveRight = "move_right";
    private static readonly StringName MoveForward = "move_forward";
    private readonly StringName MoveBackward = "move_backward";


    public void HandleInput(InputEvent @event) {
        
    }

    public Vector2 MovementVector
        => Input.GetVector(MoveLeft, MoveRight, MoveForward, MoveBackward);
}
