using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClavierScript : MonoBehaviour
{
    public Vector3 inc;

    private float increment = 0.0001f;
    // Start is called before the first frame update
    void Start()
    {
        inc = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) inc.x += increment;
        
        else if (Input.GetKey(KeyCode.S)) inc.x -= increment;
        
        else if (Input.GetKey(KeyCode.D)) inc.z -= increment;
        
        else if (Input.GetKey(KeyCode.Q)) inc.z += increment;
        
        else if (Input.GetKey(KeyCode.UpArrow)) inc.y += increment;
        
        else if (Input.GetKey(KeyCode.DownArrow)) inc.y -= increment;
        
        else inc = Vector3.zero;
    }
}