using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putHandleIn : MonoBehaviour
{
    [SerializeField]
    private GameObject handle;

    [SerializeField]
    private GameObject deviceHandle;

    // Start is called before the first frame update
    void Start() { }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "handle")
        {
            deviceHandle.SetActive(true); //replaces device with handle
            this.gameObject.SetActive(false); //removes device without handle
            handle.SetActive(false); //removes handle in hand
        }
    }
}
