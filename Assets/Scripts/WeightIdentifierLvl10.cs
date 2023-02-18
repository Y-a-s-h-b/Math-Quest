using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeightIdentifierLvl10 : MonoBehaviour
{
    public int weight;
    public WeightCalLeft weightScript;
    public Rigidbody2D rb;
    private bool flag = true;
    private bool infirst = true;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!Input.GetMouseButton(0) && infirst)
        {
            infirst = false;
            weight = other.GetComponent<SymbolDefinition>().Number - '0';

            weightScript.changeWeight();
            if (flag)
            {
                rb.constraints = RigidbodyConstraints2D.None;
                flag = false;
            }
        }       

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        infirst = true;
        weight = 0;
        weightScript.changeWeight();
    }
}
