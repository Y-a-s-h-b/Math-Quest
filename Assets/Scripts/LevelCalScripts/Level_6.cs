using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_6 : MonoBehaviour
{
    private char num1 = 'a';    
    
    public GameObject emptyBox3;
    
    private void Update()
    {
        checker();
    }

    void checker()
    {
        num1 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        

        if (num1 != 'k')
        {
            int a = num1 - '0';
            
            if (a==9)
            {
                Debug.Log("Winner");
            }
            

        }

    }
}
