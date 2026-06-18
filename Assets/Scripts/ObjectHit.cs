using UnityEngine;


public class ObjectHit : MonoBehaviour
{
    [SerializeField] Vector3 playerposition;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = playerposition;
        }
    }

}