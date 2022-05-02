using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleFirePlacementCube : MonoBehaviour
{
    public GameObject fire;
    public void Toggle()
    {
        if (fire.GetComponent<MeshRenderer>().enabled)
        {
            fire.GetComponent<MeshRenderer>().enabled = false;
            fire.GetComponent<BoundsControl>().enabled = false;
        }
        else
        {
            fire.GetComponent<MeshRenderer>().enabled = true;
            fire.GetComponent<BoundsControl>().enabled = true;
        }
    }
}
