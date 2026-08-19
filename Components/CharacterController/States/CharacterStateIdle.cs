using Godot;
using System;

public partial class CharacterStateIdle(
    CharacterController controller,
    CharacterBody3D body)
    : CharacterMoveState<CharacterStateIdle>(controller, body) {
}
