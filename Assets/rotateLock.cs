using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLock : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 0.3f;

    // Start is called before the first frame update
    void Start() { }

    void OnTriggerEnter(Collider other)
    {
        if ((other.name == "Right Hand" || other.name == "Left Hand") && Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            transform.Rotate(0, 0, zAngle: 36);
        }
    }
}
