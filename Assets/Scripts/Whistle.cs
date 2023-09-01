using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whistle : MonoBehaviour
{
    AudioSource audioSource;
    bool call = false;

    private Vector3 whistleScale;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (call)
        {
            audioSource.Play();
            transform.localScale= whistleScale;
        }
        else
        {
            audioSource.Stop();
            transform.localScale = Vector3.zero;
        }
    }
    public void setWhistleScale(Vector3 whiScale)
    {
        this.whistleScale = whiScale;
    }
    public void Call()
    {
       call = true;
    }
    public void Shut()
    {
      call= false;
    }
}
