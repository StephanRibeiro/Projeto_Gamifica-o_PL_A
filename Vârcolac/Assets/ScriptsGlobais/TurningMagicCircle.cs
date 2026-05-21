using UnityEngine;

public class TurningMagicCircle : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public GameObject magicCircle;

    void Update()
    {
        magicCircle.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
