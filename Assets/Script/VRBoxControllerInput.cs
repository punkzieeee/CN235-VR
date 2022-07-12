using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRBoxControllerInput : MonoBehaviour
{
    /* 
     * @ + C for VR Mode
     * JB 0 -> C
     * JB 1 -> A
     * JB 3 -> B
     * JB 4 -> D
     * JB 6 -> Back Trigger
     * JB 7 -> Front trigger
     * Rest of not working (@, on/off)
     */

    public void ExitVR()
    {
        if (Input.GetButton("Fire1") || Input.GetButton("A") || Input.GetButton("BackTrigger"))
        {
            SceneManager.LoadScene("TestGUI");
        }

        //SceneManager.LoadScene("TestGUI");
    }
}
