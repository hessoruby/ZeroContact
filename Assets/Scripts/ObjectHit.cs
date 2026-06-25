using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ObjectHit : MonoBehaviour

{
    [SerializeField] float crash= 0f;


    void Update()
    {
        
    }
   
    void OnCollisionEnter(Collision other)

    {if (!other.gameObject.CompareTag("Player") && !other.gameObject.CompareTag("finish") ){
       Invoke("oncrash",crash);

       
    }}
    void oncrash()
    {
         
    
            int activescene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activescene);
             
            

    }
   

}