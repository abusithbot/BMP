using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    private Animator anim;
    public float cooldownTime = 2f;
    private float nextFireTime = 0f;
    public static int noOfClicks = 0;
    float lastClickedTime = 0;
    float maxComboDelay = 1;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit1"))
        {
            anim.SetBool("Hit1", false);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit2"))
        {
            anim.SetBool("Hit2", false);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit3"))
        {
            anim.SetBool("Hit3", false);
            noOfClicks = 0;
        }


        if (Time.time - lastClickedTime > maxComboDelay)
        {
            noOfClicks = 0;
        }

        //cooldown time
        if (Time.time > nextFireTime)
        {
            // Check for mouse input
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();

            }
        }
    }

    void OnClick()
    {
        //so it looks at how many clicks have been made and if one animation has finished playing starts another one.
        lastClickedTime = Time.time;
        noOfClicks++;
        if (noOfClicks == 1)
        {
            anim.SetBool("Hit1", true);
        }
        noOfClicks = Mathf.Clamp(noOfClicks, 0, 3);

        if (noOfClicks >= 2 && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit1"))
        {
            anim.SetBool("Hit1", false);
            anim.SetBool("Hit2", true);
        }
        if (noOfClicks >= 3 && anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && anim.GetCurrentAnimatorStateInfo(0).IsName("Hit2"))
        {
            anim.SetBool("Hit2", false);
            anim.SetBool("Hit3", true);
        }
    }
}