using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CharacterController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 point;
    Camera cam;


    [Header("Speed of the character")]
    public float speed = 3.0f;

   
    

    void Start()
    {
        rb= GetComponent<Rigidbody>();
        cam = Camera.current;
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 result= new Vector3 (x,0,z);
        result.Normalize();
        rb.velocity = result*speed;

        if(x!=0 || z != 0)
        {
            transform.right = result;
        }

        if(Input.GetMouseButtonDown(0))
        {

        }
        else if (Input.GetMouseButtonDown(1))
        {

        }
       
    }
   
}
