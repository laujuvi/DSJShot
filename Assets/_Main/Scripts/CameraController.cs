using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;         // Player transform
    public Vector3 offset = new Vector3(0f, 3f, -10f);   // Camera angle
    public float smoothSpeed = 1f;

    private void LateUpdate()
    {
        // Check position player
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Move camera
        transform.position = smoothedPosition;

        // Look player
        transform.LookAt(target);
    }
}
