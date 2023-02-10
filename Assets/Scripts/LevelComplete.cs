using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public bool won;
    public GameObject[] levels;
    private int i;
    public ParticleSystem Celebration;
    public ParticleSystem Celebration2;
    public AudioSource LevelCompletion;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
        i = 0;        
    }

    // Update is called once per frame
    void Update()
    {
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
        levels[i + 1].SetActive(true);
        i += 1;
        if (i == 9)
        {
            Destroy(this);
        }
    }

    private void StartFirstLevel()
    {
        levels[0].SetActive(true);
    }

    IEnumerator levelDelay()
    {
        LevelCompletion.Play();
        Celebration.Play();
        Celebration2.Play();
        yield return new WaitForSeconds(2f);        
        levelChanger();
    }
}
