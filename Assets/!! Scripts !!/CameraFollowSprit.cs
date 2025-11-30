using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowSprit : MonoBehaviour
{
    [SerializeField]
    private Transform Target;
    [SerializeField]
    private Transform cameraTransform;
    [SerializeField]
    private Vector3 Offset;
    [SerializeField]
    private float smoothTime;

    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 targetPosition = Target.position + Offset;
        cameraTransform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        transform.LookAt(Target);
    }
}
