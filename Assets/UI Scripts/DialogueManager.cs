using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Queue<string> sentences;
    public Animator anim;
    public bool nextScene;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        nextScene = false;

    }
    public void startDialogue(Dialogue dialogue) 
    {
        anim.SetBool("IsOpen", true);
        nameText.text = dialogue.Name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        displayNext();
    }
    public void displayNext()
    {
        if(sentences.Count == 0 )
        {
            endDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    // Update is called once per frame
    void endDialogue()
    {
        anim.SetBool("IsOpen", false);

        nextScene = true;
    }
}
