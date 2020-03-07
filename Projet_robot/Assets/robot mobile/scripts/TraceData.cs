using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TraceData : MonoBehaviour
{
    private String path;
    private StreamWriter sw;
    private Transform[] cubes;
    private bool end;

    // Start is called before the first frame update
    void Start()
    {
        path = Directory.GetCurrentDirectory();
        path += "\\log.txt";
        Debug.Log("Chemin du fichier log: " + path);
        using (sw = new StreamWriter(path, false))
        {
            sw.WriteLine("Log projet robot");
            sw.WriteLine("\n");
        }

        int n = transform.childCount;
        cubes = new Transform[n-1];
        for (int i = 0; i < n-1; i++)
        {
            cubes[i] = transform.GetChild(i+1);
        }

        end = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!end)
        {
            float timer = Time.time;
            traceData("\n[" + timer + " secondes]");
            int i = 1;
            foreach (Transform cube in cubes)
            {
                if (cube.GetComponent<EnZoneDepot>().estEnZoneDepot)
                {
                    traceData("\t" + cube.name + " est en zone de depot");
                    i += 1;
                }
            }

            if (i == transform.childCount)
            {
                traceData("\nTout les cubes ont ete deposes\n" +
                          "Partie terminee en " + timer + " secondes");
                end = true;
            }
        }
    }

    public void traceData(String arg)
    {
        using (sw = new StreamWriter(path, true))
        {
            sw.WriteLine(arg);
        }
    }
}