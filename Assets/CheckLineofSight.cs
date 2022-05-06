using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckLineofSight : MonoBehaviour
{
    public GameObject target;
    public bool targetInLOS = false, actionInvoked = false;
    public string tagValue = "fire";

    public UnityEvent action;
    // Start is called before the first frame update
    public void SetActionInvokedFalse()
    {
        actionInvoked = false;
    }

    public void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, target.transform.position - transform.position, out hit) && hit.transform.tag == tagValue)
        {
            targetInLOS = true;
            if (!actionInvoked)
            {
                actionInvoked = true;
                action.Invoke();
            }
        }
            targetInLOS = false;
        //print("Raycast hit: " + hit.transform.tag);

    }
}
