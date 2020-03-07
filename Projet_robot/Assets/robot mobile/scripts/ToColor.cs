using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToColor : MonoBehaviour
{
    public GameObject cube;
    public bool estSelectionnable;
    public bool estSelectionne;
    public EnZoneDepot depot;
    
    // Start is called before the first frame update
    void Start()
    {
        To_Color(Color.black);
    }

    // Update is called once per frame
    void Update()
    {
        if(depot.estEnZoneDepot) To_Color(Color.green);
        else if (estSelectionnable) To_Color(Color.yellow);
        else if (estSelectionne) To_Color(Color.blue);
        else To_Color(Color.black);
    }

    void To_Color(Color color)
    {
        cube.GetComponent<Renderer>().material.color = color;
    }
}
