using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().enabled = true;
        print(other.gameObject.GetComponent<Renderer>());
    }

    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().enabled = false;
    }
    //     [SerializeField]
    //     public new GameObject light; // Das ist deine Lichtquelle.
    //     public float radius = 10.0f; // Der Radius der Überlappungssphäre.
    //     private List<GameObject> aliveObjects = new List<GameObject>();

    //     // Update is called once per frame
    //     void Update()
    //     {
    //         // Neue Objekte finden und zur Liste hinzufügen
    //         Collider[] nearbyObjects = Physics.OverlapSphere(
    //             light.transform.position,
    //             light.GetComponent<Light>().range
    //         );

    //         foreach (Collider collider in nearbyObjects)
    //         {
    //             GameObject obj = collider.gameObject;
    //             Vector3 directionToObj = obj.transform.position - light.transform.position;

    //             // float angle = Vector3.Angle(light.transform.forward, directionToObj);

    //             float coneAngle = 30f; // Der Öffnungswinkel deines "Lichtkegels".
    //             int numRays = 10; // Die Anzahl der Raycasts, die du ausführen willst.

    //             for (int i = 0; i < numRays; i++)
    //             {
    //                 // Berechne den Winkel für diesen Raycast.
    //                 float angle = ((float)i / (numRays - 1)) * coneAngle - (coneAngle / 2f);

    //                 // Erstelle eine Rotation, die diesen Winkel repräsentiert.
    //                 Quaternion rotation = Quaternion.Euler(0, angle, 0);

    //                 // Rotiere die Richtung deines Raycasts um diese Rotation.
    //                 Vector3 direction = rotation * transform.forward;

    //                 // Führe den Raycast aus.
    //                 Ray ray = new Ray(transform.position, direction);
    //                 Debug.DrawRay(
    //                     ray.origin,
    //                     ray.direction * light.GetComponent<Light>().range,
    //                     Color.red
    //                 );
    //             }

    //             // if (angle < light.GetComponent<Light>().spotAngle / 2) // SpotAngle ist der Gesamtöffnungswinkel des Lichtkegels, also teilen wir durch 2 um den Halbwinkel zu bekommen.
    //             // {
    //             //     // Überprüfe, ob das Objekt innerhalb des Bereichs ("Range") des Lichts liegt
    //             //     if (directionToObj.magnitude <= light.GetComponent<Light>().range)
    //             //     {
    //             //         Ray ray = new Ray(light.transform.position, directionToObj);
    //             //         Debug.DrawRay(
    //             //             ray.origin,
    //             //             ray.direction * light.GetComponent<Light>().range,
    //             //             Color.red
    //             //         ); // Zeichne eine rote Linie, um den Strahl zu visualisieren.
    //             //         RaycastHit hit;

    //             //         if (Physics.Raycast(ray, out hit, light.GetComponent<Light>().range))
    //             //         {
    //             //             if (hit.collider.gameObject == obj && !aliveObjects.Contains(obj))
    //             //             {
    //             //                 // Das Licht trifft das Objekt.
    //             //                 AddAliveObject(obj);
    //             //             }
    //             //         }
    //             //     }
    //             // }
    //         }

    //         // Überprüfen, ob die bereits erfassten Objekte immer noch vom Licht getroffen werden
    //         for (int i = aliveObjects.Count - 1; i >= 0; i--)
    //         {
    //             GameObject obj = aliveObjects[i];
    //             Vector3 direction = obj.transform.position - light.transform.position;
    //             Ray ray = new Ray(light.transform.position, direction);
    //             RaycastHit hit;

    //             if (!Physics.Raycast(ray, out hit) || hit.collider.gameObject != obj)
    //             {
    //                 // Das Licht trifft das Objekt nicht mehr.
    //                 RemoveAliveObject(obj);
    //             }
    //         }
    //     }

    //     void AddAliveObject(GameObject obj)
    //     {
    //         Renderer renderer = obj.GetComponent<Renderer>();
    //         if (renderer != null)
    //         {
    //             renderer.enabled = true;
    //         }
    //         aliveObjects.Add(obj);
    //     }

    //     void RemoveAliveObject(GameObject obj)
    //     {
    //         Renderer renderer = obj.GetComponent<Renderer>();
    //         if (renderer != null)
    //         {
    //             renderer.enabled = false;
    //         }
    //         aliveObjects.Remove(obj);
    //     }
}
