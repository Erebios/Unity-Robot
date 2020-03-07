using UnityEngine;

public class LacheObjet : MonoBehaviour
{
    public GameObject oPinceG;
    public GameObject oPinceD;
    public GameObject parentCube;
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
        if (toColor.estSelectionne && MaterialScript.b1)
        {
            oCube.transform.SetParent(parentCube.transform);
            oPinceD.transform.Rotate(Vector3.forward, -10.0f);
            oPinceG.transform.Rotate(Vector3.forward, 10.0f);
            MaterialScript.souris.b1 = false;
            MaterialScript.b1 = false;
            toColor.estSelectionne = false;
            toColor.estSelectionnable = true;
            oCube.GetComponent<Rigidbody>().isKinematic = false;
            MachineAEtatsScript.mode = MachineAEtatsScript.Mode.NAVIGATION;
        }
    }
}
