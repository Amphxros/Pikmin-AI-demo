using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private Whistle whistle;

    [Header("Speed of character controller")]
    public float speedForce;
    [Space(2)]
    [Header("Scale of the whistle")]
    public Vector3 whistleScale;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        whistle= GetComponentInChildren<Whistle>();
        if(whistle != null)
        {
            whistle.setWhistleScale(whistleScale);
        }
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

        if(Input.GetKey(KeyCode.Space))
        {
            whistle.Call();
        }
        else
        {
            whistle.Shut();
        }

    }

    void OnDrawGizmos()
    {
      
     
    }
}
