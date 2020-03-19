using UnityEngine;

/*
    "RAW" DragHandler script without RotationHandler addon

    To use it as mentioned in demo:
    1) put handler on character(make sure that character has RigidBody and Collider)
    2) modify object that you want to be dragged:
        - add Collider,
        - add Rigidbody, 
        - check IsKinematic ON,
        - modify Constraints freezes,
        - set tag 'Draggable'
    3) ready to test
*/

public class raw_DragHandler : MonoBehaviour
{
    private GameObject _draggableObject;

    public static bool IsCarrying = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_draggableObject != null && IsCarrying == false)
            {
                _draggableObject.GetComponent<Collider>().enabled = false;

                _draggableObject.transform.parent = gameObject.transform;

                IsCarrying = true;
            }
        }
        else
        {
            if (_draggableObject != null)
            {
                _draggableObject.GetComponent<Collider>().enabled = true;

                _draggableObject.transform.parent = null;

                _draggableObject = null;
            }

            IsCarrying = false;
        }      
    }

    private void OnCollisionStay(Collision block)
    {
        if (block.gameObject.CompareTag("Draggable") & IsCarrying == false)
        {
            _draggableObject = block.gameObject;
        }
    }
}
