using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsFade : MonoBehaviour
{
    public Animator transition;
    [SerializeField] private float waitTime = 1f;
    // Start is called before the first frame update   

    public void LoadNext()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(levelIndex);

    }
}
