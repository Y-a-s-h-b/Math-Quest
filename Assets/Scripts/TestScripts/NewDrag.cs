using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDrag : MonoBehaviour
{
    public bool drag;
    private float movementTime = 15f;
    private System.Nullable<Vector3> movementDestination;
    private Vector3 initialPosition;
    
    private void Start()
    {
        initialPosition = transform.position;
    }
    private void OnMouseDown()
    {
        drag = true;
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
                Debug.Log("return to original posi");
                transform.position = Vector3.Lerp(transform.position, initialPosition, movementTime * Time.fixedDeltaTime);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            returnToOriginalPlace();
        }

       

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("DropSlot"))
        {
            movementDestination = other.transform.position;          
        }
    }

    public void returnToOriginalPlace()
    {
        movementDestination = null;        
    }
   

}
