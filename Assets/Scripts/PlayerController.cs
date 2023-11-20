using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float MaxSpeed = 10;
    Vector2 dir;
    private Rigidbody2D bodyRef;
    // Start is called before the first frame update
    void Start()
    {
        bodyRef = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetAxis("Horizontal");
        Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        dir = new Vector2(horizontal, vertical);
        dir = dir.normalized;
        Debug.DrawLine(transform.position, dir * 5, Color.red);
        dir = dir * speed;
    }

    private void FixedUpdate()
    {
        bodyRef.AddForce(dir);

        if (bodyRef.velocity.x > MaxSpeed) 
        {
            bodyRef.velocity = new Vector2(MaxSpeed, bodyRef.velocity.y);
        }

    }
}
