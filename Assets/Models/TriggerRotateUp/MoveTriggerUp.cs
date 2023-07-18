using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MoveTriggerUp : MonoBehaviour
{
    [SerializeField]
    private Light Light;
    private Animator anim;
    public AudioSource audioData;
    public AudioClip clip;
    public AudioClip successClip;
    private bool triggerPushed = false; //Hebel wurde bewegt, soll nur einmal passieren
    private XRDirectInteractor directInteractor;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
        directInteractor = GetComponent<XRDirectInteractor>();
        directInteractor.selectEntered.AddListener(OnSelectEnter);
        // directInteractor.selectExited.AddListener(OnSelectExit);
    }

    private void OnSelectEnter(SelectEnterEventArgs args)
    {
        // Code, der ausgeführt wird, wenn das Objekt gegriffen wird
        StartCoroutine(PlayAnimationAndSound());
    }

    IEnumerator PlayAnimationAndSound()
    {
        anim.SetTrigger("StartTriggerRotateUp");
        audioData.PlayOneShot(clip);

        yield return new WaitForSeconds(1);

        Light.enabled = true;
    }
}
