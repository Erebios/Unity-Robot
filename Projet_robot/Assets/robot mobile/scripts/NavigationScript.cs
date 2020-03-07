using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public BougeBaseMobile baseMobile = null;
    public Vector3 increment_VR;

    // Start is called before the first frame update
    void Start()
    {
        increment_VR = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (increment_VR.magnitude > 0)
        {
            baseMobile.increment_rotation.x = increment_VR.x;
            baseMobile.increment_rotation.y = -1.0f * increment_VR.z;
            baseMobile.increment = increment_VR.x;
        }
    }
}