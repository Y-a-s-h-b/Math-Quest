using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_3 : MonoBehaviour, ILevelCheckable
{
    private char num1 = 'a';
    private char num2 = 'a';
    private char symb = 'a';
    public GameObject emptyBox1;
    public GameObject emptyBox2;
    public GameObject emptyBox3;
    private LevelComplete levelCompleteScript;
    private bool won;

    private void Start()
    {
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        
    }
   
    public bool checker()
    {
        num1 = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;
        num2 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        symb = emptyBox2.GetComponent<SymbolIdentifier>().Symbol;

        if (num1 != 'k' && num2 != 'k' &&!won)
        {
            int a = num1 - '0';
            int b = num2 - '0';
            if (a - b == 7)
            {
                levelCompleteScript.levelWon();
                won = true;
            }
            
        }

        return won;

    }
}
