using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [Header("Projectiles")]
    [SerializeField] private GameObject[] projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        ActivateProjectiles();
        Destroy(gameObject);
    }

    private void ActivateProjectiles()
    {
        foreach (GameObject projectile in projectiles)
        {
            projectile.SetActive(true);
        }
    }
}