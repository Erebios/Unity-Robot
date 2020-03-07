using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Animations;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;

public class BougeBaseMobile : MonoBehaviour
{
    public GameObject O0;
    public Vector2 increment_rotation;

    public float increment;

    // Start is called before the first frame update
    void Start()
    {
        increment_rotation = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(increment_rotation.y) <= 0.0001f) O0.transform.Translate(new Vector3(increment, 0.0f));
        else
        {
            float angle = Mathf.Acos(Vector2.Dot(Vector2.right, increment_rotation) / increment_rotation.magnitude);
            if (increment_rotation.y < 0) angle = -angle;
            O0.transform.Rotate(Vector3.up, angle);
        }
        increment_rotation = Vector2.zero;
        increment = 0.0f;
    }
}