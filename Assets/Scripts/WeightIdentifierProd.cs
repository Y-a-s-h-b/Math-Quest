using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightIdentifierProd : MonoBehaviour
{
    public int weight;
    public WeightProd weightScript;
    public Rigidbody2D rb;
    private bool flag = true;

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        weight = other.GetComponent<SymbolDefinition>().Number - '0';
        
        weightScript.changeWeight();
        if (flag)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            flag = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        weight = 0;
        weightScript.changeWeight();
    }
}
