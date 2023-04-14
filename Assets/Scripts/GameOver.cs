using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverPanel;

    // Start is called before the first frame update
    public void gameOver()
    {
        //display gameover screen
        GameOverPanel.SetActive(true);
    }

    public void ButtonGameOver()
    {
        //test button
        GameOverPanel.SetActive(false);
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene(1);
        LevelLoad.intSaver = 0;
        LevelComplete.i = 0;
        Score.lives = 3;
    }

    public void ButtonHome()
    {
        Score.lives = 3;
        SceneManager.LoadScene(0);
    }
}
