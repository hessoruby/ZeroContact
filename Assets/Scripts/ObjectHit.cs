using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ObjectHit : MonoBehaviour

{
    [SerializeField] float crash= 0f;
   
    void OnCollisionEnter(Collision other)

    {if (other.gameObject.CompareTag("Player")){
       Invoke("oncrash",crash);
       
    }}
    void oncrash()
    {
         
    
            int activescene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activescene);
             
            

    }

}