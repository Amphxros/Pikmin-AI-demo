using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listen : MonoBehaviour
{
    private PikminBehaviour pikminBehaviour;

    private void Start()
    {
        pikminBehaviour = GetComponent<PikminBehaviour>();
    }
    private void OnTriggerStay(Collider other)
    {
        Whistle w= other.GetComponent<Whistle>();
        if(w != null)
        {
            pikminBehaviour.SetPikminState(PikminState.FOLLOWING);
        }
    }
}
