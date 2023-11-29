using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float MaxSpeed = 10;
    private Rigidbody2D bodyRef;
    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent<Rigidbody2D>(out bodyRef);
    }

    // Update is called once per frame
    void Update()
    {
        dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
         Debug.DrawLine(transform.position, dir * 5, Color.red); 
        /* Input.GetAxis("Horizontal");
         Input.GetAxis("Vertical");
         float horizontal = Input.GetAxis("Horizontal");
         float vertical = Input.GetAxis("Vertical");

         dir = new Vector2(horizontal, vertical);
         dir = dir.normalized;*/
    }

    private void FixedUpdate()
    {
        bodyRef.velocity = dir * speed;
        /*
        dir = dir * speed;

        if (bodyRef.velocity.x > MaxSpeed) 
        {
            bodyRef.velocity = new Vector2(MaxSpeed, bodyRef.velocity.y);
        }*/

    }
}
