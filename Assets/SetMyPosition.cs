using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMyPosition : MonoBehaviour
{
    public void SetPosition(Transform incommingTransform)
    {
        transform.position = incommingTransform.position;
    }
}
