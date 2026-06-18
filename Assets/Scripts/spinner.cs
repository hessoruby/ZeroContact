using UnityEngine;

public class spinner : MonoBehaviour
{ [SerializeField] float x = 0f;
    [SerializeField] float y = 0f;
    [SerializeField] float z = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(x, y, z);
        
    }
}
