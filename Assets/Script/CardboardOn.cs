using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class CardboardOn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ActivatorVR("cardboard"));
    }

    public IEnumerator ActivatorVR (string str)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(str);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
}
