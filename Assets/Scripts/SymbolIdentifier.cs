using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SymbolIdentifier : MonoBehaviour
{
    public char Symbol = 'k';
    public WeightCalRight weightScript;
    public WeightCalLeft weightScript2;
    private bool infirst = true;
    private void Start()
    {
        Symbol = 'k';
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (!Input.GetMouseButton(0) && infirst)
        {
            infirst = false;
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
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        infirst = true;
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
