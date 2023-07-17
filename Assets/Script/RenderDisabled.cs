using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderDisabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Disable the renderer
        GetComponent<Renderer>().enabled = false;
    }
}
