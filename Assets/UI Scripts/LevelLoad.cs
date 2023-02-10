using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public GameObject dial;
    private DialogueManager dialogueManager;
    public Animator transition;
    [SerializeField] private float waitTime = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {

        dialogueManager = dial.GetComponent<DialogueManager>();
        if (dialogueManager.nextScene == true)
        {
            LoadNext();
        }
    }


    public void LoadNext()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(levelIndex);

    }
}
