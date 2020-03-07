using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
{
    public gere_bras gere_bras = null;
    public Vector3 increment_VR;
    
    // Start is called before the first frame update
    void Start()
    {
        increment_VR = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (increment_VR.magnitude > 0) gere_bras.increment = increment_VR;
    }
}
