using System.Runtime.InteropServices;
using UnityEngine;


public class mover : MonoBehaviour
{
    // serializefield allows us to change the value of x, y, and z in the inspector without having to change the code
    [SerializeField]float MoveSpeed = 5f;
    void Start()
    {
       PrintInstructions(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();


        
    }
    void PrintInstructions()
    {
        Debug.Log("Use the arrow keys to move the object around.");
    }
     void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime  * MoveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;
        transform.Translate(x, 0f, z);
    }
  









}
