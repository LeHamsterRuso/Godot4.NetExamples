using Godot;

/// <summary>
/// Class to handle the camera movement
/// </summary>
public partial class CameraMovement : Node3D
{
    [Export] Node3D Target;
    private float distance = 10f;
    private float height = 3f;
    private float rotationSpeed = 30f; // grades per second
    private float angle = 0f;

    /// <summary>
    /// Move camera at each loop
    /// </summary>
    /// <param name="delta">Seconds between frames</param>
    public override void _Process(double delta)
    {
        if (Target == null) return;

        angle += rotationSpeed * (float)delta;
        float radians = Mathf.DegToRad(angle);

        Vector3 targetPosition = Target.GlobalPosition;
        float x = Mathf.Cos(radians) * distance;
        float z = Mathf.Sin(radians) * distance;

        GlobalPosition = new Vector3(targetPosition.X + x, targetPosition.Y + height, targetPosition.Z + z);
        LookAt(targetPosition, Vector3.Up);
    }
}
