using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminBehaviour : MonoBehaviour
{
    private PikminState mState_;
    private Rigidbody mRigidbody_;
    public Transform target;
    void Awake()
    {
        mRigidbody_ = GetComponent<Rigidbody>();
        mState_ = new PikminState();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
