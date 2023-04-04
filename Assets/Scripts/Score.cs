using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int lives = 3;
    public CameraShake camShake;
    public GameOver gameOver;
    
    public void countScore(bool won)
    {
        if (won)
        {
            //won
        }
        else
        {
            lives -= 1;
            camShake.start = true;
        }

        if (lives<=0)
        {
            //gameover
            gameOver.gameOver();
            Debug.Log("lost");
        }
    }
}

