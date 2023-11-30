using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{ 
    public Animator animator;
    private PlayerController playerController;
    private Run run;
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
        animator.SetFloat("Run",rb2d.velocity.magnitude); //courir 
        if (Input.GetButtonDown("Sprint"))
        {
            Debug.Log("Sprint");  
            playerController.speed = 8; 
        }
        if (Input.GetButtonUp("Sprint")) 
        {
            playerController.speed = 5;        
        }
    }
}
