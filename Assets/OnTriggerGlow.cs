using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerGlow : MonoBehaviour
{

    public Material glowMaterial; 
    public GameObject glasBox;
    public GameObject player;
    public GameObject handle;
    private bool glows = false;
    private bool onGround = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = handle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.tag == "Static")
        {
            glasBox.SetActive(true);
        }*/

        if (other.tag == "GlowObject" && !glows)
        {
            other.GetComponent<Renderer>().material = glowMaterial;
            glows = true;
        }

        if (other.tag == "GlowObject" && glows && onGround)
        {
            rb.useGravity = false;
            handle.transform.SetParent(player.transform, false);
        } 

        
    }

    void OnTriggerExit(Collider other)
    {
        glasBox.SetActive(false);
        onGround = true;
    }
}
