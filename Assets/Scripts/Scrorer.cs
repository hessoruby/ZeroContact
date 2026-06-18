using UnityEngine;

public class Scrorer : MonoBehaviour
{
    int score = 0;
    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.tag != "Hit")
        { score++;
        Debug.Log("player hit:" + score);
        

        
    }
 
}}
