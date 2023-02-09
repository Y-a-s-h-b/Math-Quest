using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolIdentifier : MonoBehaviour
{
    public char Symbol = 'k';
    public WeightCalRight weightScript;
    public WeightCalLeft weightScript2;
    private void Start()
    {
        Symbol = 'k';
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Symbol = other.GetComponent<SymbolDefinition>().Number;
        if (weightScript != null)
        {
            weightScript.changeWeight();
        }
        if (weightScript2 != null)
        {
            weightScript2.changeWeight();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Symbol = 'k';
        if (weightScript != null)
        {
            weightScript.changeWeight();
        }
        if (weightScript2 != null)
        {
            weightScript.changeWeight();
        }

    }
}
