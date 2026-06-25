
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("finish"))
        {
            float active = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(0);

        
            
        }
        
    }
    
        
    



}