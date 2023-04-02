using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_4 : MonoBehaviour, ILevelCheckable
{
    private char num1 = 'a';
    private char num2 = 'a';
    private char symb = 'a';
    public GameObject emptyBox1;
    private LevelComplete levelCompleteScript;
    private bool won;

    private void Start()
    {
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        won = false;
    }
    

    public void checker()
    {
        symb = emptyBox1.GetComponent<SymbolIdentifier>().Symbol;

        if (symb != 'k')
        {            
            if (symb=='-' && !won)
            {
                won = true;
                levelCompleteScript.levelWon();

            }
            
        }

    }
}
