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
        if (other.gameObject.tag != "Static" && other.name != "Cone")
        {
            other.GetComponent<RenderDisabled>()?.Decrement();
        }
    }
}
