using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed = 0.01f;
    public float checkDistance = 0.55f;
    bool isGrounded = false;
    bool isFalling = false;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Time.deltaTime * speed * Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Time.deltaTime * speed * Vector3.left;
        }

        if(!isGrounded && rb.velocity.y < 0) {
            isFalling = true;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, checkDistance, LayerMask.GetMask("Ground"));
        isGrounded = hit.collider != null;

        if (isGrounded && isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isFalling = false;
                rb.AddForce(Vector3.up * 5f, ForceMode2D.Impulse);
            }
        }
    }
}
