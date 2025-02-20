using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Target to follow, must be assigned in the Inspector.
    public Transform target;
    // Offset of the camera relative to the target.
    public Vector3 offset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        if (target != null)
        {
            // Follow only the position while keeping the camera's rotation unchanged.
            transform.position = target.position + offset;
        }
    }
}

