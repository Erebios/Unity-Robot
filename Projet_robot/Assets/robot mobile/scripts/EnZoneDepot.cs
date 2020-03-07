using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnZoneDepot : MonoBehaviour
{
    public bool estEnZoneDepot;
    public GameObject zoneDepot;

    // Start is called before the first frame update
    void Start()
    {
        estEnZoneDepot = false;
        zoneDepot.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Depot")
        {
            estEnZoneDepot = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Depot")
        {
            estEnZoneDepot = false;
        }
    }
}