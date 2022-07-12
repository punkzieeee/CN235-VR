using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestNextScene : MonoBehaviour
{
    public void MoveToVR()
    {
        SceneManager.LoadScene("TestSceneCB");
    }

    public void MoveToMain()
    {
        SceneManager.LoadScene("TestGUI");
    }
}
