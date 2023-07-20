using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fluorescentObject : MonoBehaviour
{
    Renderer rend;
    Material material;
    Color initialColor;
    float brightness;
    bool inTrigger;

    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();
        if (rend.material.HasColor("_EmissionColor"))
        {
            material = rend.material;
            initialColor = material.GetColor("_EmissionColor");
        }
        else
        {
            // Debug.Log("material not emissive");
        }

        brightness = 0.1f;
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        Color color = initialColor;

        if (material.GetColor("_EmissionColor").r > .001 && inTrigger == false)
        {
            brightness -= .01f;
        }
        else if (material.GetColor("_EmissionColor").r <= .001)
        {
            rend.enabled = false;
            
            // Debug.Log(material.GetColor("_EmissionColor").r);
        }

        color = new Color(
            color.r * Mathf.Pow(2, brightness),
            color.g * Mathf.Pow(2, brightness),
            color.b * Mathf.Pow(2, brightness),
            color.a
        );
        material.SetColor("_EmissionColor", color * 1.4f);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cone")
        {
            rend.enabled = true;

            Color color = initialColor;
            inTrigger = true;
            if (material.GetColor("_EmissionColor").r < 1)
            {
                brightness += .4f;
                // Debug.Log(material.GetColor("_EmissionColor").r);
            }
            color = new Color(
                color.r * Mathf.Pow(2, brightness),
                color.g * Mathf.Pow(2, brightness),
                color.b * Mathf.Pow(2, brightness),
                color.a
            );
            material.SetColor("_EmissionColor", color * 1.4f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
}
