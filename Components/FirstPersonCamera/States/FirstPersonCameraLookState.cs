using Godot;
using System;

public partial class FirstPersonCameraLookState(
    FirstPersonCamera camera, CharacterBody3D body) 
    : FirstPersonCameraState<FirstPersonCameraLookState>(camera, body) {

    public override void Enter() {
        GD.Print("c1");
        base.Enter();
    }

    public override void Process() {
        
    }
}
