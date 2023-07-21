using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMirror : MonoBehaviour
{

    [SerializeField]
    private GameObject playerCamera;

    [SerializeField]
    private GameObject mirrorCamera;

    [SerializeField]
    private GameObject mirror;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayDirection = mirrorCamera.transform.position - playerCamera.transform.position;

        Ray ray = new Ray(playerCamera.transform.position, rayDirection);
        RaycastHit[] hits = Physics.RaycastAll(ray);

        foreach (RaycastHit hit in hits )
        {
            if (hit.transform.gameObject != mirror)
            {
                continue;
            }
            if (hit.transform.gameObject == mirror)
            {
                Debug.Log(hit.transform.gameObject.name);

                Vector3 reflectedDirection = Vector3.Reflect(rayDirection, hit.normal);
                mirrorCamera.transform.rotation = Quaternion.LookRotation(reflectedDirection, hit.normal);

                Debug.DrawRay(mirrorCamera.transform.position, reflectedDirection);
            }
        }
        Debug.DrawRay(playerCamera.transform.position, rayDirection);
    }
}
