using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Static")
        {
            EnableGameObjectAndChildren(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Static")
        {
            DisableGameObjectAndChildren(other.gameObject);
        }
    }

    void EnableGameObjectAndChildren(GameObject parent)
    {
        parent.layer = LayerMask.NameToLayer("Default");
        if (parent.GetComponent<Renderer>() != null)
        {
            parent.GetComponent<Renderer>().enabled = true;
        }
        if (parent.GetComponent<Rigidbody>() != null)
        {
            parent.GetComponent<Rigidbody>().useGravity = true;
        }

        foreach (Transform child in parent.transform)
        {
            EnableGameObjectAndChildren(child.gameObject);
        }
    }

    void DisableGameObjectAndChildren(GameObject parent)
    {
        parent.layer = LayerMask.NameToLayer("IlluminatedObjects");
        if (parent.GetComponent<Renderer>() != null)
        {
            parent.GetComponent<Renderer>().enabled = false;
        }
        if (parent.GetComponent<Rigidbody>() != null)
        {
            parent.GetComponent<Rigidbody>().useGravity = false;
        }

        foreach (Transform child in parent.transform)
        {
            DisableGameObjectAndChildren(child.gameObject);
        }
    }
}
