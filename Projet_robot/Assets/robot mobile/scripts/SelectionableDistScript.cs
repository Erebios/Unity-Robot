using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionableDistScript : MonoBehaviour
{
    public ToColor toColor;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "O7tierce")
        {
            if (!toColor.estSelectionne)
            {
                toColor.estSelectionnable = true;
            }
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.name == "O7tierce")
        {
            toColor.estSelectionnable = false;
        }
    }
}