using Godot;

public partial class PlayerInputContext : IActionHandler {
    private static readonly StringName moveLeft = "move_left";
    private static readonly StringName moveRight = "move_right";
    private static readonly StringName moveForward = "move_forward";
    private static readonly StringName moveBackward = "move_backward";
    private static readonly StringName sprint = "sprint";

    public Vector2 MovementVector { get; private set; }
    public bool HasMovementInput { get; private set; }
    public bool IsSprinting { get; private set; }


    public void HandleInput(InputEvent @event) {
    }

    public void OnPhysicsProcess() {
        MovementVector = Input.GetVector(moveLeft, moveRight, moveForward, moveBackward);
        HasMovementInput = MovementVector != Vector2.Zero;
        IsSprinting = Input.IsActionPressed(sprint); 
    }

}
