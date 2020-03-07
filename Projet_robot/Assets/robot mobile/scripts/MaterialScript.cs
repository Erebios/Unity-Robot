using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour
{
    public SourisScript souris;
    public ClavierScript clavier;
    
    public Vector3 increment;
    public bool b1, b2, b3;

    // Start is called before the first frame update
    void Start()
    {
        increment = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        b1 = souris.b1;
        b2 = souris.b2;
        b3 = souris.b3;

        increment = clavier.inc;
    }
}
