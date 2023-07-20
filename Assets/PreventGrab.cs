using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PreventGrab : MonoBehaviour
{
    private XRGrabInteractable XRGI;

    void Start()
    {
        XRGI = GetComponent<XRGrabInteractable>();
        XRGI.enabled = false; // Interaktion deaktiviert am Anfang
        // this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }

    // Update is called once per frame
    void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "glasbox")
        {
            XRGI.enabled = true;
        }
    }
}
