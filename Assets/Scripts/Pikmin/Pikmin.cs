using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum PikminState { PLANTED, IDLE, FOLLOW, CARRY}
public class Pikmin : MonoBehaviour
{
    public PikminManager manager;
    void Start()
    {
        manager.pikminFollow.AddListener( x => onFollow());
        manager.pikminThrow.AddListener(x => onIdle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onPlanted()
    {

    }
    private void onIdle()
    {

    }
    private void onFollow()
    {

    }
    private void onCarry()
    {

    }

}
