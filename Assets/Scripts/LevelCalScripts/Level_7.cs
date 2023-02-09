using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Level_7 : MonoBehaviour
{
    private char num1 = 'a';
    private char num2 = 'a';
    private char num3 = 'a';
    public GameObject emptyBox1;
    public GameObject emptyBox2;
    public GameObject emptyBox3;
    private void Update()
    {
        checker();
    }

    void checker()
    {
        num1 = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;
        num2 = emptyBox2.GetComponent<SymbolIdentifier>().Symbol;
        num3 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        ;
        if (num1 != 'k' && num2 != 'k' && num3 != 'k')
        {
            
            int a = num1 - '0';
            int b = num2 - '0';
            int c = num3 - '0';
            
            if ((a*b)+c == 5)
            {
                Debug.Log("Winner");
            }
            
        }
       
    }
}