using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        var position = player.transform.position;
        transform.position = new Vector3(position.x, position.y, -10f);
    }
}
