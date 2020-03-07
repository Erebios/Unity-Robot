using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MachineAEtatsScript : MonoBehaviour
{
    public SelectionScript SelectionScript;
    public MaterialScript MaterialScript;
    public NavigationScript NavigationScript;
    public Mode mode;

    public enum Mode
    {
        NAVIGATION,
        SELECTION,
        MANIPULATION
    }

    void Start()
    {
        mode = Mode.NAVIGATION;
    }

    void Update()
    {
        if (MaterialScript.b1)
        {
            switch (mode)
            {
                case Mode.NAVIGATION:
                    mode = Mode.SELECTION;
                    break;
                case Mode.SELECTION:
                    mode = Mode.NAVIGATION;
                    break;
            }

            MaterialScript.souris.b1 = false;
        }


        switch (mode)
        {
            case Mode.NAVIGATION:
                if (MaterialScript.b2) NavigationScript.increment_VR = MaterialScript.increment;
                else NavigationScript.increment_VR = Vector3.zero;
                break;
            case Mode.SELECTION:
                SelectionScript.increment_VR = MaterialScript.increment;
                break;
            case Mode.MANIPULATION:
                if (MaterialScript.b2) NavigationScript.increment_VR = MaterialScript.increment;
                else NavigationScript.increment_VR = Vector3.zero;
                break;
        }
    }
}