using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelsFallDown : MonoBehaviour
{
    Rigidbody woodPanel;

    [SerializeField]
    Renderer wardrobe;
    bool startAudio;

    // Start is called before the first frame update
    void Start()
    {
        woodPanel = this.GetComponent<Rigidbody>();
        startAudio = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!wardrobe.enabled && woodPanel.GetComponent<Renderer>().enabled)
        {
            woodPanel.isKinematic = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (audio && startAudio)
        {
            audio.Play();
            startAudio = false;
        }
    }
}
