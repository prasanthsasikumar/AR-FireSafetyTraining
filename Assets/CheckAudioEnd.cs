using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckAudioEnd : MonoBehaviour
{
    private AudioSource audioObject;
    private bool invokeEndActionPending = false, invokeStartActionPending = false;

    public UnityEvent endPlayaction, startPlayAction;
    private void Start()
    {
        audioObject = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (audioObject.isPlaying)
        {
            invokeEndActionPending = true;
            if (invokeStartActionPending)
            {
                invokeStartActionPending = false;
                startPlayAction.Invoke();
            }
        }
        else
        {
            invokeStartActionPending = true;
            if (invokeEndActionPending)
            {
                invokeEndActionPending = false;
                endPlayaction.Invoke();
            }
        }
    }
}
