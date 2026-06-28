using UnityEngine;

public class Mover : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 5f;

    [Header("Respawn Settings")]
    [SerializeField] private Vector3 spawnPosition = new Vector3(-7.457f, -0.265f, 14.96f);
    [SerializeField] private float fallLimit = -10f;

    private void Start()
    {
        PrintInstructions();
    }

    private void Update()
    {
        MovePlayer();
        CheckIfPlayerFell();
    }

    private void PrintInstructions()
    {
        Debug.Log("Use the arrow keys to move the object around.");
    }

    private void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    private void CheckIfPlayerFell()
    {
        if (transform.position.y < fallLimit)
        {
            RespawnPlayer();
        }
    }

    private void RespawnPlayer()
    {
        transform.position = spawnPosition;
    }
}