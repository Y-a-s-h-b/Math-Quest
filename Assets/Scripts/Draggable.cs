using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public bool IsDragging;
    public Vector3 LastPosition;

    private Collider2D colliderObj;
    private DragController dragController;

    private float movementTime = 15f;
    private System.Nullable<Vector3> movementDestination;

    void Start()
    {
        colliderObj = GetComponent<Collider2D>();
        dragController = FindObjectOfType<DragController>();
    }

    private void FixedUpdate()
    {
        if (movementDestination.HasValue)
        {
            if (IsDragging)
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
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("innnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn");
        Draggable collidedDraggable = other.GetComponent<Draggable>();

        if (collidedDraggable != null && dragController.LastDragged.gameObject == gameObject)
        {
            ColliderDistance2D colliderDistanec2D = other.Distance(colliderObj);
            Vector3 diff = new Vector3(colliderDistanec2D.normal.x, colliderDistanec2D.normal.y)* colliderDistanec2D.distance;
            transform.position -= diff;
        }

        if (other.CompareTag("DropSlot"))
        {
            movementDestination = other.transform.position;
        }
    }

}
