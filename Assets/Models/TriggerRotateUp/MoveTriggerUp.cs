using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveTriggerUp : MonoBehaviour
{
    [SerializeField]
    private Light LightToTurnOn;

    [SerializeField]
    private Light LightToTurnOff;

    [SerializeField]
    private GameObject Cone;

    [SerializeField]
    private GameObject ThisCone;

    [SerializeField]
    private GameObject Flashlight;

    [SerializeField]
    private Light Spotlight;

    [SerializeField]
    private GameObject FlashlightCone;

    [SerializeField]
    private GameObject Lamp;

    private Animator anim;
    public AudioSource audioData;
    public AudioClip clip;

    // // public AudioClip successClip;
    private bool triggerPushed = false; //Hebel wurde bewegt, soll nur einmal passieren

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggerPushed && other.name != "Cone")
        {
            triggerPushed = true;
            // Light.enabled = false;
            StartCoroutine(PlayAnimationAndSound());
        }
    }

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        // Code, der ausgeführt wird, wenn das Objekt gegriffen wird
        StartCoroutine(PlayAnimationAndSound());
    }

    IEnumerator PlayAnimationAndSound()
    {
        Cone.transform.localScale = new Vector3(0.57f, 0.67f, 0.57f);
        anim.SetTrigger("triggerHebel");
        audioData.PlayOneShot(clip);

        yield return new WaitForSeconds(1);

        LightToTurnOff.enabled = false;
        LightToTurnOn.enabled = true;
        Spotlight.enabled = true;
        ThisCone.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
        Lamp.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        Flashlight.SetActive(true);
    }
}
