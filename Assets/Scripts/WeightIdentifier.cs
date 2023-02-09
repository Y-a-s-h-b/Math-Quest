using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class WeightIdentifier : MonoBehaviour
{
    public int weight;
    public WeightSum weightScript;    
    public Rigidbody2D rb;
    private bool flag=true;

   
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
