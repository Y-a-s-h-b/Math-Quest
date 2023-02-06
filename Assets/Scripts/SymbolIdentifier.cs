using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolIdentifier : MonoBehaviour
{
    public char Symbol='k';
    private void OnTriggerEnter2D(Collider2D other)
    {
        Symbol = other.GetComponent<SymbolDefinition>().Number;
    }

}
