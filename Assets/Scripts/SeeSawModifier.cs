using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SeeSawModifier : MonoBehaviour
{
    public Rigidbody2D leftside;
    public Rigidbody2D rightside;
    private float weightLeft;
    private float weightRight;
    private Transform currTrans;
    public float comeBackSpeed;
    private bool posiFiexer = false;
    


    void Start()
    {
       
    }

    private void Update()
    {
        weightLeft = leftside.mass;
        weightRight = rightside.mass;
        currTrans = this.transform;
        Debug.Log(weightLeft);

        if (weightLeft==weightRight && weightLeft>1) 
        {
            setRotation();            
        }

        
    }

    void setRotation()
    {        
        transform.rotation = Quaternion.Lerp(currTrans.rotation,new Quaternion(0f,0f,0f,1), Time.deltaTime * comeBackSpeed);
        this.GetComponent<BoxCollider2D>().enabled = false;
    }


}
