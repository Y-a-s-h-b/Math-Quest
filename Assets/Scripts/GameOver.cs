using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
