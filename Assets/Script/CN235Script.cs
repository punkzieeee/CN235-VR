using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CN235Script : MonoBehaviour
{
    public GameObject player;
    public Transform teleportToCabin1; // koordinat (3, 2.4, -29)
    public Transform teleportToHangar1; // koordinat (3.25, 0.02, -36)
    public Transform teleportToCabin2; // koordinat (-12.7, 2.45, -29)
    public Transform teleportToHangar2; // koordinat (-12.8, 0.02, -22.5)

    public void MoveToVR()
    {
        SceneManager.LoadScene("CN235");
    }
    public void MoveToMain()
    {
        if (Input.GetButton("Fire1"))
            SceneManager.LoadScene("CN235 - Main Menu");
    }
    // masuk kabin lewat pintu belakang
    public void TeleportToCabin1()
    {
        if (Input.GetButton("Fire1"))
            player.transform.position = teleportToCabin1.transform.position;
    }
    // keluar kabin lewat pintu belakang
    public void TeleportFromCabinToHangar1()
    {
        if (Input.GetButton("Fire1"))
            player.transform.position = teleportToHangar1.transform.position;
    }
    // masuk kabin lewat pintu depan
    public void TeleportToCabin2()
    {
        if (Input.GetButton("Fire1"))
            player.transform.position = teleportToCabin2.transform.position;
    }
    // keluar kabin lewat pintu depan
    public void TeleportFromCabinToHangar2()
    {
        if (Input.GetButton("Fire1"))
            player.transform.position = teleportToHangar2.transform.position;
    }
}
