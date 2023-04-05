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
    public static int i=0;
    public ParticleSystem Celebration;
    public ParticleSystem Celebration2;
    public AudioSource LevelCompletion;
    public AudioSource NextLevelButtonSound;
    public GameObject Fade;
    private LevelsFade levelsFade;
    public GameObject nextButton;
    public GameObject WindowChanger;
    public GameObject checkButton;

    // Start is called before the first frame update
    void Start()
    {
        
        levelsFade = Fade.GetComponent<LevelsFade>();
        won = false;
        StartFirstLevel();
        if (LevelLoad.intSaver==1)
        {
            i = 0;
        }
        Debug.Log("LevelVariable_levelcomplete: " + i);
    }

    // Update is called once per frame
   
    public void levelWon()
    {
        Debug.Log("levelwon function called");
        won = true;        
        LevelCompletion.Play();
        Celebration.Play();
        Celebration2.Play();
        nextButton.SetActive(true);
                        
    }

    private void levelChanger()
    {        
        levels[i].SetActive(false); 
        
        if (i==2)
        {
            levelsFade.LoadNext();            
        }
        if (i==5)
        {
            levelsFade.LoadNext();
        }
        if (i!=2 && i!=5 && i!=9)
        {
            levels[i + 1].SetActive(true);           
            
        }        
        if (i == 9)
        {
            levelsFade.LoadNext();
        }
        i += 1;
        if (i>9)
        {
            Destroy(this);
        }
    }

    private void StartFirstLevel()
    {
        levels[i].SetActive(true);
        StartCoroutine(CheckButtonOnDelay(0.6f));
    }
   

    IEnumerator LevelChangeDelay()
    {
        yield return new WaitForSeconds(1f);                  
        levelChanger();
    }
    public void Newbutton()
    {
        NextLevelButtonSound.Play();
        if (i!=2 && i!=5 && i!=9)
        {
            WindowChanger.GetComponent<Animator>().Play("LevelChange");
            StartCoroutine(LevelChangeDelay());
            
        }
        else
        {
            levelChanger();
        }

        Debug.Log("level"+i);
        if (i != 1 && i != 6 && i != 8)
        {
            StartCoroutine(CheckButtonOnDelay(1f));
        }
        

    }

    IEnumerator CheckButtonOnDelay(float timeDelay)
    {
        yield return new WaitForSeconds(timeDelay);
        checkButton.SetActive(true);
    }
    private void Update()
    {
        Debug.Log("LevelVariable_levelcomplete: " + i);
    }

}
