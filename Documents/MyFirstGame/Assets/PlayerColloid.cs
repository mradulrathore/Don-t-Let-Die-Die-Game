
using UnityEngine;

public class PlayerColloid : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisioninfor)
    {
        if(collisioninfor.collider.tag=="Obstacles")
        {
            movement.enabled = false;
        }
    }
}
