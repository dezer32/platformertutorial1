using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    public GameObject respawn;
    public GameObject player;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = respawn.transform.position;
        }
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y);
    }
}
