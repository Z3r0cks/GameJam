using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderDisabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DisableGameObjectAndChildren(gameObject);
    }

    void DisableGameObjectAndChildren(GameObject parent)
    {
        // Deaktiviere das Renderer-Component des GameObjects
        if (parent.GetComponent<Renderer>() != null)
        {
            parent.GetComponent<Renderer>().enabled = false;
        }

        // Setze das Layer des GameObjects
        parent.layer = LayerMask.NameToLayer("IlluminatedObjects");

        // Deaktiviere das Rigidbody-Component des GameObjects
        if (parent.GetComponent<Rigidbody>() != null)
        {
            parent.GetComponent<Rigidbody>().useGravity = false;
        }

        // Rufe diese Funktion rekursiv für alle Kinder auf
        foreach (Transform child in parent.transform)
        {
            DisableGameObjectAndChildren(child.gameObject);
        }
    }
}
