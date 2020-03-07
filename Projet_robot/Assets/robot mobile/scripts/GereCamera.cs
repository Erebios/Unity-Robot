using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GereCamera : MonoBehaviour
{
    public SourisScript sourisScript;
    public Camera mainCamera, robotCamera, pinceCamera;

    private int courante;

    private Camera[] cameras = new Camera[3];
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = true;
        robotCamera.enabled = false;
        pinceCamera.enabled = false;
        courante = 0;
        cameras[0] = mainCamera;
        cameras[1] = robotCamera;
        cameras[2] = pinceCamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (sourisScript.b3)
        {
            Switch();
            sourisScript.b3 = false;
        }
    }
    
    void Switch()
    {
        cameras[courante%3].enabled = false;
        courante++;
        cameras[courante%3].enabled = true;
    }
}
