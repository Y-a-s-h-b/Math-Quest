using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestOnly : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressedd");
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Not pressed");
            gameObject.GetComponent<BoxCollider2D>().enabled = true;

        }
       
    }
}
