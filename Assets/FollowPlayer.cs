using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; 
    public float speed = 1f;

    void Update()
    {
        Vector3 targetPosition = Vector3.Lerp(
            transform.position, 
            player.position, 
            speed * Time.deltaTime
        );
        targetPosition.z = transform.position.z;

        transform.position = targetPosition;
    }
}
