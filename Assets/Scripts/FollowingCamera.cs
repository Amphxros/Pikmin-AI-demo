using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.25f;
    Vector3 currentVelocity= Vector3.one;
  
    void Start()
    {
        offset= transform.position - target.position;
    }

    
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset,ref currentVelocity,smoothTime);
    }
}
