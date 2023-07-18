using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakVase : MonoBehaviour
{
    [SerializeField] GameObject fractured;
    [SerializeField] float BreakHeight;
    public float breakForce;
    Vector3 startPosition;
    Vector3 currentPosition;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        currentPosition = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position;
        distance = Vector3.Distance(startPosition, currentPosition);
        if (distance > BreakHeight) {
            BreakIt();
        }

    }

    public void BreakIt()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);

        foreach (Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>()) {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }
}
