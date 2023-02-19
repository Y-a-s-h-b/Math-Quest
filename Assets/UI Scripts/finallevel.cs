using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finallevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Player"))
        {
            
            StartCoroutine(LoadLevel(3));
        }
    }
    
    IEnumerator LoadLevel(int levelIndex)
    {
    //transition.SetTrigger("Start");
    yield return new WaitForSeconds(5f);
    SceneManager.LoadScene(levelIndex);
    }
}
