using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putHandleIn : MonoBehaviour
{

    public GameObject handle;
    public GameObject device;
    public GameObject deviceHandle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == handle)
        {
            Debug.Log("ich berühre das Gerät");
            deviceHandle.SetActive(true); //replaces device with handle
            device.SetActive(false); //removes device without handle
            handle.SetActive(false); //removes handle in hand
        }
    }
}
