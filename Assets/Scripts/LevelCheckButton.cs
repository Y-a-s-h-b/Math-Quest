using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckButton : MonoBehaviour
{
    public GameObject parentOfObject;
    private ILevelCheckable subScript;

    public void checkCaller()
    {
        subScript = parentOfObject.GetComponentInChildren<ILevelCheckable>();
        if (subScript != null)
        {
            subScript.checker();
        }
        else
        {
            Debug.Log("Error");
        }
    }

    public void testButton()
    {
        Debug.Log("int");
    }
}
