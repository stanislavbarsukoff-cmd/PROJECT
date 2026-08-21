using Godot;

public interface IFirstPersonCameraStateMachine;
public partial class FirstPersonCameraState<TState>(
    FirstPersonCamera camera, CharacterBody3D body)
    : State<IFirstPersonCameraStateMachine, TState> {
    protected FirstPersonCamera _camera = camera;
    protected CharacterBody3D _body = body;
}
