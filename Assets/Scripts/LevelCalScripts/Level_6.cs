using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_6 : MonoBehaviour, ILevelCheckable
{
    private char num1 = 'a';        
    public GameObject emptyBox3;
    private LevelComplete levelCompleteScript;
    private bool won;
    private void Start()
    {
        levelCompleteScript = FindObjectOfType<LevelComplete>();
        won = false;
    }


    public void checker()
    {
        num1 = emptyBox3.GetComponent<SymbolIdentifier>().Symbol;
        
        if (num1 != 'k')
        {
            int a = num1 - '0';
            
            if (a==9 && !won)
            {
                won = true;
                levelCompleteScript.levelWon();                
            }
            
        }
    }
}
