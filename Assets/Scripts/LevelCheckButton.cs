using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckButton : MonoBehaviour
{
    public GameObject parentOfObject;
    private ILevelCheckable subScript;
    public bool won = false;
    public GameObject checkButton;
    public Score score;

    public void checkCaller()
    {
        won = false;
        subScript = parentOfObject.GetComponentInChildren<ILevelCheckable>();
        if (subScript != null)
        {
            won = subScript.checker();
        }
        else
        {
            Debug.Log("Error");
        }

        if (won)
        {
            checkButton.SetActive(false);
            Debug.Log("button deactivated");
        }
              

        score.countScore(won);

    }

  
}
