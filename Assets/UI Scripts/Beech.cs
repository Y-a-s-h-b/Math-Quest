using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beech : MonoBehaviour
{
    
    public GameObject uiObject;
    public DialogueTrigger dialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        uiObject.SetActive(false);
        if (LevelLoad.intSaver==2)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }

    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Player"))
        {
            uiObject.SetActive(true);
            dialogueTrigger.TriggerDialogue();

        }

    }
}
