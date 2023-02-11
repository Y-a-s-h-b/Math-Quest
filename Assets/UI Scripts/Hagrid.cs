using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hagrid : MonoBehaviour
{
    public GameObject uiObject;
    public DialogueTrigger dialogueTrigger;
    private Animator anim;
    public GameObject Book;
    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
        dialogueTrigger = GetComponent<DialogueTrigger>();
        uiObject.SetActive(false);
        if (LevelLoad.intSaver==3)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            anim.SetTrigger("destroy");
           
            
        }
        
    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Player"))
        {
            uiObject.SetActive(true);
            dialogueTrigger.TriggerDialogue();
            gameObject.SetActive(true);

        }

    }
}
