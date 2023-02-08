using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_5 : MonoBehaviour
{
    private char num1 = 'a';    
    public GameObject emptyBox1;
    // public GameObject emptyBox3;
    private void Update()
    {
        checker();
    }

    void checker()
    {
        num1 = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;        

        if (num1 != 'a')
        {
            int a = num1 - '0';
            
            if (a == 8)
            {
                Debug.Log("Winner");
            }

        }

    }
}
