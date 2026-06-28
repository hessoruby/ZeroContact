using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (HasAlreadyScored(collision))
            return;

        IncreaseScore();
        MarkObjectAsHit(collision);
    }

    private bool HasAlreadyScored(Collision collision)
    {
        return collision.gameObject.CompareTag("Hit");
    }

    private void IncreaseScore()
    {
        score++;
        Debug.Log($"Player Score: {score}");
    }

    private void MarkObjectAsHit(Collision collision)
    {
        collision.gameObject.tag = "Hit";
    }
}