using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorOpen : MonoBehaviour
{
    public int totalBoards = 8; // Number of boards to be removed
    private int removedBoards = 0;

    private XRGrabInteractable XRGI;

    void Start()
    {
        XRGI = GetComponent<XRGrabInteractable>(); // Initialisierung von XRGrabInteractable
        XRGI.enabled = false; // Interaktion deaktiviert am Anfang
    }

    public void NotifyBoardRemoved()
    {
        removedBoards++;
        if (removedBoards >= totalBoards)
        {
            XRGI.enabled = true; // Aktivieren der Interaktion, wenn alle Bretter entfernt wurden
        }
    }
}
