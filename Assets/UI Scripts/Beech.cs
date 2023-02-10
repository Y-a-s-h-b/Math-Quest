using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beech : MonoBehaviour
{
    
    public GameObject uiObject;
    public DialogueTrigger dialogueTrigger;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger = GetComponent<DialogueTrigger>();
        uiObject.SetActive(false);
        anim = GetComponent<Animator>();
        if (LevelLoad.intSaver==2)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            anim.SetTrigger("dest");
            
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
