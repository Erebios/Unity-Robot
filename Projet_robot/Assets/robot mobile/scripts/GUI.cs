using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    public GereCamera GereCamera;
    public MachineAEtatsScript MachineAEtatsScript;
    public GameObject sol;
    
    
    // Start is called before the first frame update
    void Start()
    {
        sol.GetComponent<Renderer>().material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnGUI()
    {
        GUILayout.Box("Etat: "+MachineAEtatsScript.mode);

        GUILayout.Box(Mathf.FloorToInt(Time.time) + " seconds");

        Camera[] cameras = {GereCamera.mainCamera, GereCamera.robotCamera, GereCamera.pinceCamera};
        if (cameras[0].enabled) GUILayout.Box("Caméra générale\nappuyez sur espace pour passer en caméra robot");
        else if (cameras[1].enabled) GUILayout.Box("Caméra robot\nappuyez sur espace pour passer en caméra pince");
        else if (cameras[2].enabled) GUILayout.Box("Caméra pince\nappuyez sur espace pour passer en caméra générale");
    }
}
