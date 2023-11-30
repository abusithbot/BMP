using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator animator;
    private PlayerController playerController;
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", rb2d.velocity.magnitude); //peut importe la direction la vitesse change, sans vitesse la vitesse est a 0
                                                             // animator.SetFloat("Speed",playerController.transform.position.y);
    }
}
