using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class GenereObjetScript : MonoBehaviour
{
    public GameObject prefab;
    public TraceData tracer;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int k = 0; k < 10; k++)
        {
            GameObject obj = Instantiate(prefab,
                new Vector3(Random.Range(-7.5f, 7.5f), 0.0f, Random.Range(-7.5f, 7.5f)),
                Quaternion.identity);
            obj.transform.parent = prefab.transform.parent;
            obj.name = "OCube<" + k + ">";
            Debug.Log("Cube " + (k + 1) + " crée");
        }
        prefab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}