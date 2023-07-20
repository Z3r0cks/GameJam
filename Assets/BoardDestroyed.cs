using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardDestroyed : MonoBehaviour
{
    [SerializeField]
    private DoorOpen DoorLeft;

    [SerializeField]
    private DoorOpen DoorRight;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!rb.isKinematic)
        {
            DoorLeft.NotifyBoardRemoved();
            DoorRight.NotifyBoardRemoved();
            this.enabled = false;
        }
    }
}
