using UnityEngine;

public class RotateNumber : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    public float period = 1f;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        Debug.Log(other.name);
        Debug.Log(other.name != "Cone");
        if (other.name != "Cone" && Time.time > nextActionTime)
        {
            Debug.Log("Rotated");
            nextActionTime += period;
            transform.Rotate(0, 0, 36);
        }
    }
}
