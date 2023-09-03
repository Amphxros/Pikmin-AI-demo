using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    [Header("UI parameters")]
    public GameObject fraction;
    public Vector3 uioffset;
    public Transform canvas;

    [Header("Item parameters")]
    public int pikminNeeded;
    public float radius;

    [HideInInspector]
    public GameObject fractionObject;

    private void Awake()
    {
        fractionObject = Instantiate(fraction, canvas);
        fractionObject.SetActive(false);

    }



}
