using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class Level_1 : MonoBehaviour
{
    private char num1 = 'a';
    private char num2 = 'a';    
    public GameObject emptyBox1;    
    public GameObject emptyBox3;
    private LevelComplete levelCompleteScript;
    private bool won;

    private void Start()
    {
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        won = false;
    }
    private void Update()
    {
        checker();
        
    }

    void checker()
    {
        num1 = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;
        num2 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;

        Debug.Log(num1);
        Debug.Log(num2);

        if (num1 != 'k' && num2 != 'k')
        {
            int a = num1 - '0';
            int b = num2 - '0';
            if (a + b == 10 && !won)
            {
                
                levelCompleteScript.levelWon();
                won = true;                
                
            }
            
        }

    }
}
