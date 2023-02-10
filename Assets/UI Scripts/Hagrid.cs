using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hagrid : MonoBehaviour
{
    public GameObject uiObject;
    public DialogueTrigger dialogueTrigger;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        uiObject.SetActive(false);
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
