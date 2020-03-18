using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField]
    private Transform _characterTransform;

    [SerializeField]
    public float Height = 10f;

    [SerializeField]
    private float Distance = 20f;

    [SerializeField]
    private float Angle = 45f;

    [SerializeField]
    private float SmoothSpeed = 0.5f;

    private Vector3 _refVelocity;  // to make camera work smooth

    private void Start()
    {
        HandleCamera();
    }

    private void FixedUpdate()
    {
        HandleCamera();
    }

    protected virtual void HandleCamera()
    {
        // Build world position Vector
        Vector3 worldPosition = (Vector3.forward * -Distance) + (Vector3.up * Height);

        // Build our rotated Vector
        Vector3 rotatedVector = Quaternion.AngleAxis(Angle, Vector3.up) * worldPosition;

        // Move our position
        Vector3 flatTargetPosition = _characterTransform.position;
        flatTargetPosition.y = 0f;

        Vector3 finalPosition = flatTargetPosition + rotatedVector;

        transform.position = Vector3.SmoothDamp
            (transform.position, finalPosition, ref _refVelocity, SmoothSpeed);

        transform.rotation = Quaternion.LookRotation(-rotatedVector);
    }
}
