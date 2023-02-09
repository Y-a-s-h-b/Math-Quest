using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_4 : MonoBehaviour
{
    
    private char symb = 'a';
    public GameObject emptyBox1;
   
    private void Update()
    {
        checker();
    }

    void checker()
    {
        
        symb = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;

        if (symb != 'k')
        {
            if (symb=='-')
            {
                Debug.Log("Winner");
            }
            
        }

    }
}
