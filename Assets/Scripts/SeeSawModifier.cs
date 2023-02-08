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
    private bool posiFiexer = true;
    private float timeCount = 0.0f;
    private float massMultiplier;
    public WeightSum weightScript;


    void Start()
    {
        massMultiplier = weightScript.massMultiplier;
        Debug.Log("mass multi"+ massMultiplier);
    }

    private void Update()
    {

        weightLeft = leftside.mass;
        weightRight = rightside.mass;
        currTrans = this.transform;
        Debug.Log(weightLeft);

        if (weightLeft == weightRight && weightLeft > massMultiplier)
        {
            transform.rotation = Quaternion.Lerp(currTrans.rotation, new Quaternion(0f, 0f, 0f, 1), timeCount * comeBackSpeed);
            timeCount = timeCount + Time.deltaTime;
            if (posiFiexer)
            {
                this.GetComponent<BoxCollider2D>().enabled = false;
                posiFiexer = false;
            }
        }

    }

    void setRotation()
    {        
        transform.rotation = Quaternion.Lerp(currTrans.rotation,new Quaternion(0f,0f,0f,1), timeCount * comeBackSpeed);
        timeCount = timeCount + Time.deltaTime;
        if (posiFiexer)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            posiFiexer = false;
        }
    }

   
}
