using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float jump;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Animator anim;
    public float timeToBlink;
    public Joystick joystick;
    private float movX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        anim.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        movX = joystick.Horizontal * speed;
        float verticalMove = joystick.Vertical;
            rb.velocity = new Vector2(movX*speed,rb.velocity.y );
            if (joystick.Horizontal >= 0.2f && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
            transform.eulerAngles = new Vector3(0, 180, 0);
            
                anim.SetTrigger("Run");
            }
            else if (joystick.Horizontal <= -0.2f && anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movX = -speed;
                anim.SetTrigger("Run");
            }
            else
            {
                anim.SetTrigger("Idle");
                movX = 0;
            }
            /*if (joystick.Horizontal < 0.2f && joystick.Horizontal > -0.2f && joystick.Vertical < 0.5f)
            {
                anim.Play("Idle_01");
            }*/
            if (verticalMove >= 0.5f && (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") || anim.GetCurrentAnimatorStateInfo(0).IsName("Run")))
            {
                rb.AddForce(transform.up * jump);
                anim.SetTrigger("Jump");
            }
    }
}
