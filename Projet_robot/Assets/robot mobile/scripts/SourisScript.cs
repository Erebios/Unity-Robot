using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourisScript : MonoBehaviour
{
    public bool b1, b2, b3;

    // Start is called before the first frame update
    void Start()
    {
        b1 = false;
        b2 = false;
        b3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            b1 = true;
        }
        else if (Input.GetButton("Fire2"))
        {
            b2 = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (b3) b3 = false;
            else b3 = true;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            b2 = false;
        }
    }
}