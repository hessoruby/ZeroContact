using UnityEngine;

public class vanisher : MonoBehaviour
{
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;
    [SerializeField] GameObject platform3;
    [SerializeField] GameObject platform4;

    void Update()
    {
        if ((int)Time.time % 4 < 2)
        {
            
            platform1.GetComponent<MeshRenderer>().enabled = true;
            platform1.GetComponent<Collider>().enabled = true;

            
            platform2.GetComponent<MeshRenderer>().enabled = false;
            platform2.GetComponent<Collider>().enabled = false;

            
            platform3.GetComponent<MeshRenderer>().enabled = true;
            platform3.GetComponent<Collider>().enabled = true;

            
            platform4.GetComponent<MeshRenderer>().enabled = false;
            platform4.GetComponent<Collider>().enabled = false;
        }
        else
        {
            
            platform1.GetComponent<MeshRenderer>().enabled = false;
            platform1.GetComponent<Collider>().enabled = false;

            
            platform2.GetComponent<MeshRenderer>().enabled = true;
            platform2.GetComponent<Collider>().enabled = true;

            
            platform3.GetComponent<MeshRenderer>().enabled = false;
            platform3.GetComponent<Collider>().enabled = false;

            
            platform4.GetComponent<MeshRenderer>().enabled = true;
            platform4.GetComponent<Collider>().enabled = true;
        }
    }
}