using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDialogue : MonoBehaviour
{
    public GameObject uiObject;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);

    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        if (Collider.gameObject.CompareTag("Respawn"))
        {
            uiObject.SetActive(true);

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiObject.SetActive(false);
    }
}
