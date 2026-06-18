using UnityEngine;

public class DROPER : MonoBehaviour
{ [SerializeField] float T = 3f;
MeshRenderer lolmeshRenderer;
Rigidbody lolrigidbody;

 void Start()
    {
        lolmeshRenderer = GetComponent<MeshRenderer>();
        lolmeshRenderer.enabled = false;
        lolrigidbody = GetComponent<Rigidbody>();
        lolrigidbody.useGravity = false;
    }
   
    void Update()
    {
       
        //Debug.Log("how much time elapsed per frame:" + Time.time);
        if (Time.time > T)
        {
            lolrigidbody.useGravity = true;
            lolmeshRenderer.enabled = true;
        }
        else
        {
            lolrigidbody.useGravity = false;
        }
    }
}
