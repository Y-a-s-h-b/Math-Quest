using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightProd : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public float massMultiplier;
    private int weight1;
    private int weight2;
    private Rigidbody2D rb;
    private int k = 20;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1f;
    }

    private void Update()
    {

        //this.transform.position = posiGameObj.transform.position;

    }

    public void changeWeight()
    {
        weight1 = slot1.GetComponent<WeightIdentifierProd>().weight;
        weight2 = slot2.GetComponent<WeightIdentifierProd>().weight;
        Debug.Log("Weigh1");
        Debug.Log(weight1);
        Debug.Log(weight2);
        int knew = weight1 * weight2;
        Debug.Log(knew);
        
                
        rb.mass = ((knew) * massMultiplier)+1 ;
        rb.simulated = false;
        rb.simulated = true;
    }
}
