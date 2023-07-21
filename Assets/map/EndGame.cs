using System.Collections;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    new AudioSource audio;

    [SerializeField]
    private GameObject text;

    [SerializeField]
    private Light Flashlight;

    [SerializeField]
    private Light TableLampLight;

    [SerializeField]
    private GameObject TableLamp;

    [SerializeField]
    private Light ProjectorLight;

    [SerializeField]
    private GameObject Zahl;

    [SerializeField]
    private AudioSource Sound;

    [SerializeField]
    private GameObject Corridor;

    [SerializeField]
    private GameObject Wall;

    [SerializeField]
    private GameObject Room;

    private int leverPushedCount;

    // Start is called before the first frame update
    void Start()
    {
        leverPushedCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (leverPushedCount == 3)
        {
            text.SetActive(true);
            StartCoroutine(TurnOffLightsAfterDelay(5));
        }
    }

    IEnumerator TurnOffLightsAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Flashlight.enabled = false;
        TableLampLight.enabled = false;
        ProjectorLight.enabled = false;
        Zahl.SetActive(false);
        Sound.Stop();
        //text.SetActive(false);
        Wall.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        Room.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        Corridor.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
        TableLamp.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.black);
    }

    public void CountLeversPushed()
    {
        leverPushedCount += 1;
        audio.Play();
    }
}
