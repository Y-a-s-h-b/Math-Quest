using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSawModifierLvl10 : MonoBehaviour
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
    public WeightCalLeft weightScript;
    private LevelComplete levelCompleteScript;
    private bool won;

    void Start()
    {
        massMultiplier = weightScript.massMultiplier;
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        won = false;
    }

    private void Update()
    {

        weightLeft = leftside.mass;
        weightRight = rightside.mass;
        currTrans = this.transform;


        if (weightLeft == weightRight && weightLeft > massMultiplier)
        {
            transform.rotation = Quaternion.Lerp(currTrans.rotation, new Quaternion(0f, 0f, 0f, 1), timeCount * comeBackSpeed);
            timeCount = timeCount + Time.deltaTime;
            if (posiFiexer && !won)
            {
                this.GetComponent<BoxCollider2D>().enabled = false;
                posiFiexer = false;
                won = true;
                levelCompleteScript.levelWon();
            }
        }

    }

    void setRotation()
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
