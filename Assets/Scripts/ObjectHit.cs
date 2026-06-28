using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    [Header("Crash Settings")]
    [SerializeField] private float crashDelay = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (ShouldRestart(collision))
        {
            Invoke(nameof(RestartLevel), crashDelay);
        }
    }

    private bool ShouldRestart(Collision collision)
    {
        return !collision.gameObject.CompareTag("Player") &&
               !collision.gameObject.CompareTag("finish");
    }

    private void RestartLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}