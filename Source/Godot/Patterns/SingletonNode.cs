using Godot;

public partial class SingletonNode<T> : Node where T : Node {
    public static T Instance { get; private set; }

    public override void _EnterTree() {
        Instance = this as T;
    }
}
