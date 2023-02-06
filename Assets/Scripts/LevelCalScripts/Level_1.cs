using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    private char num1 = 'a';
    private char num2 = 'a';
    private char symb = 'a';
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
        num2 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        symb = emptyBox2.GetComponent<SymbolIdentifier>().Symbol;

        if (num1 != 'a' && num2 != 'a' && symb != 'a')
        {
            int a = num1 - '0';
            int b = num2 - '0';
            if (a + b == 4 && symb == '+')
            {
                Debug.Log("Winner");
            }
            else
            {
                Debug.Log("loser");
            }
        }
        else
        {
            Debug.Log("loser");
        }
    }
}
