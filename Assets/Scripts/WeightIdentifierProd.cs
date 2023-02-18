using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class WeightIdentifierProd : MonoBehaviour
{
    public int weight;
    public WeightProd weightScript;
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
