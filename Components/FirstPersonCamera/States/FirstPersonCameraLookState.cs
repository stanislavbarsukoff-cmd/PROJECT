using Godot;
using System;

public partial class FirstPersonCameraLookState(
    FirstPersonCamera camera, CharacterBody3D body) 
    : FirstPersonCameraState<FirstPersonCameraLookState>(camera, body) {

    private float _xRotation;
    private float _yRotation;

    private float _xTargetRotation;
    private float _yTargetRotation;

    public override void Enter() {
        GD.Print("c1");
        base.Enter();
    }

    public override void Process() {
        //Vector3 mouseInput = Input.GetAxis("", "", "", "");
    }
}
