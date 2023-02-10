using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public bool won;
    public GameObject[] levels;
    private static int i=0;
    public ParticleSystem Celebration;
    public ParticleSystem Celebration2;
    public AudioSource LevelCompletion;
    public Animator fade;
    // Start is called before the first frame update
    void Start()
    {        
        won = false;                
                        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartFirstLevel();
        }
    }

    public void levelWon()
    {
        won = true;
        Debug.Log("Winner");
        StartCoroutine(levelDelay());
                
    }

    private void levelChanger()
    {        
        levels[i].SetActive(false);
        if (i==2)
        {
            fade.SetTrigger("Start");
            SceneManager.LoadScene(1);
            
        }
        if (i==5)
        {
            fade.SetTrigger("Start");
            SceneManager.LoadScene(1);            
        }
        if (i!=2 && i!=5)
        {
            levels[i + 1].SetActive(true);
        }
        i += 1;
        if (i == 9)
        {
            Destroy(this);
        }
    }

    private void StartFirstLevel()
    {
        levels[i].SetActive(true);
    }

    IEnumerator levelDelay()
    {
        LevelCompletion.Play();
        Celebration.Play();
        Celebration2.Play();
        yield return new WaitForSeconds(2f);        
        levelChanger();
    }

    IEnumerator simpleDelay()
    {
        yield return new WaitForSeconds(4f);
    }
}
