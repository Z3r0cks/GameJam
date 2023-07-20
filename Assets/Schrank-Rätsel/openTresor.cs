using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openTresor : MonoBehaviour
{
    [SerializeField]
    GameObject schloss1;

    [SerializeField]
    GameObject schloss2;

    [SerializeField]
    GameObject schloss3;

    int zahl1 = 0;
    int zahl2 = 0;
    int zahl3 = 0;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        schloss1.transform.localEulerAngles = new Vector3(
            schloss1.transform.localEulerAngles.x,
            schloss1.transform.localEulerAngles.y,
            0
        );
        schloss2.transform.localEulerAngles = new Vector3(
            schloss2.transform.localEulerAngles.x,
            schloss2.transform.localEulerAngles.y,
            0
        );
        schloss3.transform.localEulerAngles = new Vector3(
            schloss3.transform.localEulerAngles.x,
            schloss3.transform.localEulerAngles.y,
            0
        );

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // check if first lock is in the correct position
        if (schloss1.transform.localEulerAngles.z == 180)
        {
            zahl1 = 6;
        }

        // check if second lock is in the correct position
        if (schloss2.transform.localEulerAngles.z == 0)
        {
            zahl2 = 1;
        }

        // check if third lock is in the correct position
        if (schloss3.transform.localEulerAngles.z == 288)
        {
            zahl3 = 9;
        }

        // check if all numbers are correct
        if (zahl1 == 6 && zahl2 == 1 && zahl3 == 9)
        {
            anim.SetTrigger("openTresor");
        }
    }
}
