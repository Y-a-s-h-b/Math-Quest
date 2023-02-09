using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_5 : MonoBehaviour
{
    private char num1 = 'a';    
    public GameObject signEmptyBox;
    public GameObject emptyBox3;
    private char symb = 'a';
    private void Update()
    {
        checker();
    }

    void checker()
    {
        num1 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        symb = signEmptyBox.GetComponent<SymbolIdentifier>().Symbol;

        if (num1 != 'k' && symb!='k')
        {
            int a = num1 - '0';
            
            if (symb=='x' && a==8)
            {
                Debug.Log("Winner");
            }
            else if (symb=='+' && a==6 )
            {
                Debug.Log("Winner");
            }
            else
            {
                Debug.Log(a);
                Debug.Log(symb);
            }

        }

    }
}
