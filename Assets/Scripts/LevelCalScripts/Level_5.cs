using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_5 : MonoBehaviour, ILevelCheckable
{
    private char num1 = 'a';
    public GameObject signEmptyBox;
    public GameObject emptyBox3;
    private char symb = 'a';
    private LevelComplete levelCompleteScript;
    private bool won;
    private void Start()
    {
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        won = false;
    }
   
    public bool checker()
    {
        num1 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        symb = signEmptyBox.GetComponent<SymbolIdentifier>().Symbol;

        if (num1 != 'k' && symb != 'k' &&!won)
        {
            int a = num1 - '0';

            if (symb == 'x' && a == 8)
            {
                won = true;
                levelCompleteScript.levelWon();
            }
            else if (symb == '+' && a == 6)
            {
                won = true;
                levelCompleteScript.levelWon();

            }


        }

        return won;

    }
}

