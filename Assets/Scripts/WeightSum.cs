using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeightSum : MonoBehaviour
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
        weight1 = slot1.GetComponent<WeightIdentifier>().weight;
        weight2 = slot2.GetComponent<WeightIdentifier>().weight;

        int knew = weight1 + weight2;
        rb.mass = (knew+1) * massMultiplier;
        rb.simulated = false;
        rb.simulated = true;
    }
}
