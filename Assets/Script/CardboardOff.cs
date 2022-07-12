using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class CardboardOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeactivatorVR("none"));
    }

    public IEnumerator DeactivatorVR(string str)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(str);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = false;
    }
}
