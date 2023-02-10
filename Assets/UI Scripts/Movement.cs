using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    [SerializeField] float jump;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Animator anim;
    public Joystick joystick;
    private float movX;
    private StandaloneInputModule inputModule;
    public GameObject joy;
    public Transform Witch1Trns;
    public Transform Witch2Trns;
    public Transform Witch3Trns;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim= GetComponent<Animator>();
        inputModule = GetComponent<StandaloneInputModule>();
        anim.enabled = true;
        if (LevelLoad.intSaver == 1)
        {
            this.transform.position = Witch1Trns.position;
        }
        else if (LevelLoad.intSaver ==2)
        {
            this.transform.position = Witch2Trns.position;
        }
        else if (LevelLoad.intSaver ==3)
        {
            this.transform.position = Witch3Trns.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = joystick.Horizontal * speed;
        float verticalMove = joystick.Vertical;
            rb.velocity = new Vector2(movX*speed,rb.velocity.y );
            if (joystick.Horizontal >= 0.5f)
            {
            transform.eulerAngles = new Vector3(0, 180, 0);
            
                //anim.SetTrigger("Run");
            anim.SetBool("idle", false);
            anim.SetBool("walk", false);
            anim.SetBool("running", true);
        }
            else if (joystick.Horizontal <= -0.5f )
            {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movX = -speed;
                //anim.SetTrigger("Run");
            anim.SetBool("idle", false);
            anim.SetBool("walk", false);
            anim.SetBool("running", true);
        }

            else if(joystick.Horizontal > 0f && joystick.Horizontal < 0.5f) 
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("idle", false);
            anim.SetBool("running", false);
            anim.SetBool("walk", true);
            
        }
            else if(joystick.Horizontal > -0.5f && joystick.Horizontal < 0f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("idle", false);
            anim.SetBool("running", false);
            anim.SetBool("walk", true);
        }
            else
            {
            //anim.SetTrigger("Idle");
            anim.SetBool("idle", true);
            anim.SetBool("running", false);
            anim.SetBool("walk", false);
            movX = 0;
            }
        /*if (joystick.Horizontal < 0.2f && joystick.Horizontal > -0.2f && joystick.Vertical < 0.5f)
        {
            anim.Play("Idle_01");
        }*/

    }
    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "NPC")
        {
            anim.SetBool("running", false);
            anim.SetTrigger("hi");
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            joystick.enabled= false;
            joy.SetActive(false);
            anim.enabled= false;
        }
    }   
    private void OnTriggerExit2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "NPC")
        {
            rb.constraints = RigidbodyConstraints2D.None;
            joy.SetActive(true);
            anim.enabled = true;
            joystick.enabled = true;
        }
    }
    
}
