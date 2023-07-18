using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOutCollider : MonoBehaviour
{
    [SerializeField]
    private Light Light;

    [SerializeField]
    private GameObject Cone;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin (XR Rig)")
        {
            Light.enabled = false;
            Cone.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}
