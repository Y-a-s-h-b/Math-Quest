using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckButton : MonoBehaviour
{
    public GameObject parentOfObject;
    private ILevelCheckable subScript;
    private bool won = false;
    public GameObject checkButton;

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
    }

  
}
