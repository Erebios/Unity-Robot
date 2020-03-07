using UnityEngine;

public class PrendreObjet : MonoBehaviour
{
    public GameObject oPinceG;
    public GameObject oPinceD;
    public GameObject oTool;
    public GameObject oCube;
    public ToColor toColor;
    public MaterialScript MaterialScript;
    public MachineAEtatsScript MachineAEtatsScript;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toColor.estSelectionnable && MaterialScript.b1)
        {
            transform.SetParent(oTool.transform);
            oPinceD.transform.Rotate(Vector3.forward, 10.0f);
            oPinceG.transform.Rotate(Vector3.forward, -10.0f);
            MaterialScript.souris.b1 = false;
            MaterialScript.b1 = false;
            toColor.estSelectionne = true;
            toColor.estSelectionnable = false;
            oCube.GetComponent<Rigidbody>().isKinematic = true;
            MachineAEtatsScript.mode = MachineAEtatsScript.Mode.MANIPULATION;
            MachineAEtatsScript.SelectionScript.increment_VR = 0.001f*Vector3.up;
        }
    }
}
