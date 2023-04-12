using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour
{
    //[SerializeField] float jump;
    [SerializeField]
    float speed;
    Rigidbody2D rb;

    [HideInInspector]
    public Animator anim;
    public Joystick joystick;
    private float movX;
    private StandaloneInputModule inputModule;
    public GameObject joy;
    public Transform Witch1Trns;
    public Transform Witch2Trns;
    public Transform Witch3Trns;

    public GameObject end;

    private bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        inputModule = GetComponent<StandaloneInputModule>();
        anim.enabled = true;
        if (LevelLoad.intSaver == 1)
        {
            this.transform.position = Witch1Trns.position;
        }
        else if (LevelLoad.intSaver == 2)
        {
            this.transform.position = Witch2Trns.position;
        }
        else if (LevelLoad.intSaver == 3)
        {
            this.transform.position = Witch3Trns.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        movX = joystick.Horizontal * speed;

        if (joystick.Horizontal >= 0.5f && isMoving == true)
        {
            rb.velocity = new Vector2(movX * speed, rb.velocity.y);
            transform.eulerAngles = new Vector3(0, 180, 0);

            //anim.SetTrigger("Run");
            anim.SetBool("idle", false);
            anim.SetBool("walk", false);
            anim.SetBool("running", true);
        }
        else if (joystick.Horizontal <= -0.5f && isMoving == true)
        {
            rb.velocity = new Vector2(movX * speed, rb.velocity.y);
            transform.eulerAngles = new Vector3(0, 0, 0);
            movX = -speed;
            //anim.SetTrigger("Run");
            anim.SetBool("idle", false);
            anim.SetBool("walk", false);
            anim.SetBool("running", true);
        }
        else if (joystick.Horizontal > 0f && joystick.Horizontal < 0.5f && isMoving == true)
        {
            rb.velocity = new Vector2(movX * speed, rb.velocity.y);
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("idle", false);
            anim.SetBool("running", false);
            anim.SetBool("walk", true);
        }
        else if (joystick.Horizontal > -0.5f && joystick.Horizontal < 0f && isMoving == true)
        {
            rb.velocity = new Vector2(movX * speed, rb.velocity.y);
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
        /*if (joystick.Vertical > 0.5f && !isJumping)
        {
            //rb.AddForce(new Vector2(rb.velocity.x, jump));
            anim.SetTrigger("jump");
            anim.Play("Jump");
            rb.AddForce(Vector3.up * jump, ForceMode2D.Impulse);
            
            isJumping = true;

        }
        if(joystick.Vertical < 0.5f)
        {
            isJumping = false;
            

        }*/
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.tag == "NPC")
        {
            anim.SetBool("running", false);
            anim.SetBool("Wave", true);
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            joystick.enabled = false;
            joy.SetActive(false);
            anim.enabled = false;
        }
        if (Collider.gameObject.CompareTag("Book"))
        {
            isMoving = false;
            joystick.enabled = false;
            Debug.Log("Entered");
            joystick.HandleRange = 0;
            joystick.DeadZone = 100;

            anim.SetBool("running", false);
            anim.SetBool("idle", true);

            anim.SetBool("idle", true);
            anim.SetBool("Wave", true);

            StartCoroutine(FinalScene());
        }
    }

    IEnumerator FinalScene()
    {
        yield return new WaitForSeconds(3f);
        end.SetActive(true);
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
