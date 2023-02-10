using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldHag : MonoBehaviour
{
    public GameObject uiObject;
    public DialogueTrigger dialogueTrigger;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger= GetComponent<DialogueTrigger>();
        uiObject.SetActive(false);
        anim= GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if(Collider.gameObject.CompareTag("Player"))
        {
            uiObject.SetActive(true);
            dialogueTrigger.TriggerDialogue();
            anim.SetTrigger("speak");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
