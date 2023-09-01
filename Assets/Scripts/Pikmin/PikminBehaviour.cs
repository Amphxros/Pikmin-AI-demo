using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikminBehaviour : MonoBehaviour
{
    private PikminState mState_;
    private Rigidbody mRigidbody_;

    public Transform targetFollow;
    public Transform targetOnCarry;

    void Awake()
    {
        mRigidbody_ = GetComponent<Rigidbody>();
        mState_ = PikminState.IDLE;
        
    }

    public void SetPikminState(PikminState pik)
    {
        mState_ = pik;
    }

    // Update is called once per frame
    void Update()
    {
       switch(mState_)
        {
            case PikminState.IDLE:
                break;
            case PikminState.FOLLOWING:
                break;
            case PikminState.CARRYING:
                break;
            case PikminState.ATTACKING: 
                break;
        } 
    }

    private void onIdle()
    {

    }

    private void onFollow()
    {

    }

    private void onAttack()
    {

    }
    private void onCarry()
    {

    }

}
