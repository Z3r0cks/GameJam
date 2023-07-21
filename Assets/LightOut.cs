using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOut : MonoBehaviour
{
    [SerializeField]
    new Light light;

    [SerializeField]
    GameObject emmissionObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Right Hand" || other.name == "Left Hand")
        {
            light.enabled = !light.enabled; // Toggle light enabled state
        }
    }

    void Update()
    {
        if (light.enabled == true)
        {
            Debug.Log(emmissionObject);
            this.gameObject.tag = "Static";
            Material material = emmissionObject.GetComponent<Renderer>().material;
            material.SetColor("_EmissionColor", Color.white);
        }
        else
        {
            this.gameObject.tag = "Untagged";
            Material material = emmissionObject.GetComponent<Renderer>().material;
            material.SetColor("_EmissionColor", Color.black);
        }
    }
}
