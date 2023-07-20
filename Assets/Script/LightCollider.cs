using UnityEngine;

public class LightCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Static" && other.name != "Cone")
        {
            other.GetComponent<RenderDisabled>()?.Increment();
        }
        if (other.name == "Cone")
        {
            other.gameObject.tag = "Static";
        }
    }

    void OnTriggerExit(Collider other)
    {
        var emissionColor = 0f;
        try
        {
            emissionColor = other.gameObject
                .GetComponent<Renderer>()
                .material.GetColor("_EmissionColor")
                .r;
        }
        catch (System.Exception)
        {
            emissionColor = 0f;
        }

        if (other.gameObject.tag != "Static" && other.name != "Cone" && emissionColor <= .001 && other.name == "handle")
        {
            other.GetComponent<RenderDisabled>()?.Decrement();
        }
    }
}
