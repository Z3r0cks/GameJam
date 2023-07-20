using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorHandleDisabled : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Renderer>().enabled = false;
    }
}
