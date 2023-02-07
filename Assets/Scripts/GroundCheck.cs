using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour

{
    private bool checkingGround;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheck;
    public float circleRadius = 0.1f;
    [SerializeField]private Transform obj;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(this.transform.localPosition.x);
        checkingGround = Physics2D.OverlapCircle(groundCheck.position, circleRadius, groundLayer);
        fix();
    }
    void fix()
    {
        if (checkingGround)
        {
            transform.localPosition = new Vector3(transform.localPosition.x,1, 0);
            transform.localRotation = Quaternion.Euler(0,0,0);

        }
    }
}
