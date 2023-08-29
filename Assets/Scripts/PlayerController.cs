using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Speed of character controller")]
    public float speedForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.right = new Vector3(x, 0, y);

        Vector3 result = new Vector3(x, 0, y) * speedForce;
        result.Normalize();
        rb.velocity = result;

    }

    void OnDrawGizmos()
    {
      
     
    }
}
