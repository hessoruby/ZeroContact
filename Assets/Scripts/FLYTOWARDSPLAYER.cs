
using UnityEngine;

public class FLYTOWARDSPLAYER : MonoBehaviour
{
[SerializeField] float SPEED = 0.6f;
[SerializeField] Transform player;
Vector3 playerposition;






   
    void Start()
    {
        
        playerposition = player.transform.position;
        

        
    }

        void Update()
    { 
    DestroyWhenReached();
    movetoplayer();
        
    }


    void Awake() {
        gameObject.SetActive(false);

        
     }
    void movetoplayer()
    {
        transform.position=Vector3.MoveTowards(transform.position, playerposition, Time.deltaTime *SPEED);
    }
    
    void DestroyWhenReached()
    {
        if (transform.position == playerposition)
        {
            Destroy(gameObject);
        }
    }
}
