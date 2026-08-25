using Godot;

public partial class PlayerInputContext : IActionHandler {
    private static readonly StringName MoveLeft = "move_left";
    private static readonly StringName MoveRight = "move_right";
    private static readonly StringName MoveForward = "move_forward";
    private static readonly StringName MoveBackward = "move_backward";

    public Vector2 MovementVector { get; private set; }
    public bool HasMovementInput { get; private set; }


    public void HandleInput(InputEvent @event) {
        //13123
        GD.Print(1);
    }

    public void OnPhysicsProcess() {
        MovementVector = Input.GetVector(MoveLeft, MoveRight, MoveForward, MoveBackward);
        HasMovementInput = MovementVector != Vector2.Zero;
    }

}
