
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform players;
    public Vector3 offset;


    // Update is called once per frame
    void Update()
    {
        transform.position = players.position + offset;
    }
}
