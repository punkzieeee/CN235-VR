using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // debug
        if (Input.anyKeyDown)
            Debug.Log(Input.inputString);

        float h = Input.GetAxis("Horizontal"); // mendapat input horizontal
        float v = Input.GetAxis("Vertical"); // mendapat input vertikal

        //transform.position += new Vector3 (h * playerSpeed * Time.deltaTime, 0f, v * playerSpeed * Time.deltaTime);

        // VRBox CB use @ + C
        if (v > 0)
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime; // kontrol maju
        if (v < 0)
            transform.position = transform.position - Camera.main.transform.forward * playerSpeed * Time.deltaTime; // kontrol mundur
        if (h > 0)
            transform.position = transform.position + Camera.main.transform.right * playerSpeed * Time.deltaTime; // kontrol belok kanan
        if (h < 0)
            transform.position = transform.position - Camera.main.transform.right * playerSpeed * Time.deltaTime; // kontrol belok kiri

    }
}
