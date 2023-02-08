using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_4 : MonoBehaviour
{
    private char num1 = 'a';
    private char num2 = 'a';
    private char symb = 'a';
    public GameObject emptyBox1;
    public GameObject emptyBox2;
   // public GameObject emptyBox3;
    private void Update()
    {
        checker();
    }

    void checker()
    {
        num1 = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;
        //num2 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        symb = emptyBox2.GetComponent<SymbolIdentifier>().Symbol;

        if (num1 != 'a' && symb != 'a')
        {
            int a = num1 - '0';
            //int b = num2 - '0';
            if (symb=='-' && a==7)
            {
                Debug.Log("Winner");
            }
            
        }

    }
}
