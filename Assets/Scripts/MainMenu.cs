using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private AudioSource ButtonSound1;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        LevelLoad.intSaver = 0;
        LevelComplete.i = 0;
        Score.lives = 3;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ButtonClickSound()
    {
        ButtonSound1.Play();
    }

    private void Update()
    {
        /*if (Input.GetMouseButton(0))
        {
            ButtonSound1.Play();
        }*/
    }
}
