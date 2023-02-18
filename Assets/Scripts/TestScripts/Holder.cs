using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public string numName="";
    private GameObject initialGameobj;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.GetComponent<NewDrag>().drag)
        {            
            if (numName=="")
            {
                numName = collision.name;
                initialGameobj = collision.gameObject;
                Debug.Log(numName);
            }

            if (numName != collision.name)
            {
                swap(initialGameobj);
                numName = collision.name;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        numName = "";
        Debug.Log("Value reset");
    }

    void swap(GameObject obj)
    {        
        obj.GetComponent<NewDrag>().returnToOriginalPlace();
    }


}
