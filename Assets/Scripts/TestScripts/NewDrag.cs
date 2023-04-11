using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDrag : MonoBehaviour
{
    public bool drag;
    private float movementTime = 15f;
    private System.Nullable<Vector3> movementDestination;
    private Vector3 initialPosition;
    private char NumberDef;
    private AudioSource buttonSound;
    private void Start()
    {
        initialPosition = transform.position;
        NumberDef = this.GetComponent<SymbolDefinition>().Number;
        buttonSound = this.GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        drag = true;
        ButtonClickAudio();
    }

    private void OnMouseUp()
    {
        drag = false;
    }

    private void Update()
    {
        if (drag)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(MousePos);
        }
    }
    private void FixedUpdate()
    {
        if (movementDestination.HasValue)
        {
            
            if (drag)
            {
                movementDestination = null;
                return;
            }
            if (transform.position == movementDestination)
            {
                gameObject.layer = Layer.Default;
                movementDestination = null;
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, movementDestination.Value, movementTime * Time.fixedDeltaTime);
            }
        }
        else
        {
            if (!drag)
            {
                
                transform.position = Vector3.Lerp(transform.position, initialPosition, movementTime * Time.fixedDeltaTime);
            }
        }

        //if (input.getkey(keycode.a))
        //{
        //    returntooriginalplace();
        //}       

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (NumberDef == '+' || NumberDef == '-' || NumberDef == 'x')
        {
            if (other.CompareTag("DropSlotSigns"))
            {
                movementDestination = other.transform.position;
            }
        }
        else
        {
            if (other.CompareTag("DropSlot"))
            {
                movementDestination = other.transform.position;
            }
        }/*
        if (other.CompareTag("DropSlot") && (NumberDef!='+' || NumberDef != '-' || NumberDef != 'x'))
        {
            movementDestination = other.transform.position;
            Debug.Log("number box_NewDrag");
        }

        if (other.CompareTag("DropSlotSigns") && (NumberDef == '+' || NumberDef == '-' || NumberDef == 'x'))
        {
            movementDestination = other.transform.position;
            Debug.Log("sign box_NewDrag");
        }*/
    }

    public void returnToOriginalPlace()
    {
        movementDestination = null;        
    }
   
    private void ButtonClickAudio()
    {
        buttonSound.Play();
    }

}
