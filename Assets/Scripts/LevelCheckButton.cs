using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckButton : MonoBehaviour
{
    public GameObject parentOfObject;
    private ILevelCheckable subScript;
    private bool won = false;

    public void checkCaller()
    {
        subScript = parentOfObject.GetComponentInChildren<ILevelCheckable>();
        if (subScript != null)
        {
            won = subScript.checker();
        }
        else
        {
            Debug.Log("Error");
        }

        Debug.Log(won);
    }

    public void testButton()
    {
        Debug.Log("int");
    }
}
