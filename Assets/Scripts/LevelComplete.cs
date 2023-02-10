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
    public GameObject Fade;
    private LevelsFade levelsFade;
    public GameObject nextButton;
    public GameObject WindowChanger;
    // Start is called before the first frame update
    void Start()
    {   
        levelsFade = Fade.GetComponent<LevelsFade>();
        won = false;
        StartFirstLevel();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);       
            
        
    }

    public void levelWon()
    {        
        won = true;
        Debug.Log("Winner");
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
   

    IEnumerator LevelChangeDelay()
    {
        yield return new WaitForSeconds(1f);                  
        levelChanger();
    }
    public void Newbutton()
    {
        if (i!=2 && i!=5)
        {
            WindowChanger.GetComponent<Animator>().Play("LevelChange");
            StartCoroutine(LevelChangeDelay());
        }
        else
        {
            levelChanger();
        }
         
    }
        
}
