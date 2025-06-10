using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Player player;
    public float speed = 5f;
    public Vector2 offset = new Vector2(0, 1.5f);

    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        playerPosition.z = transform.position.z; 
        playerPosition += (Vector3)offset;

        transform.position = Vector3.Lerp(transform.position, playerPosition, Time.deltaTime * speed);
    }
}
