using Godot;
using System;

public partial class FirstPersonCamera : Camera3D {
    [Export] private CharacterBody3D _body;
    [Export]public float Sensitivity { get; set;}

    private StateMachine<IFirstPersonCameraStateMachine> _stateMachine;

}
