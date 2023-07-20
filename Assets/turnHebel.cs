using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnHebel : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    [SerializeField]
    AudioSource audioData;

    [SerializeField]
    private AudioClip clip;
    
    void Start() { }

    private bool triggerPushed = false;

    void OnTriggerEnter(Collider other)
    {
        if (!triggerPushed && (other.name == "Right hand" || other.name == "Left Hand"))
        {
            Debug.Log("in if");
            triggerPushed = true;
            anim.SetTrigger("triggerHebel");
            audioData.PlayOneShot(clip);
        }
    }
}
