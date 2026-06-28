using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Header("Rotation Speed (Degrees Per Frame)")]
    [SerializeField] private float xRotation = 0f;
    [SerializeField] private float yRotation = 0f;
    [SerializeField] private float zRotation = 0f;

    private void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}