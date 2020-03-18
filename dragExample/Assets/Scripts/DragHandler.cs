using UnityEngine;

public class DragHandler : MonoBehaviour
{
    private GameObject _draggableObject;

    public static bool IsCarrying = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_draggableObject != null)
            {
                _draggableObject.GetComponent<BoxCollider>().enabled = false;

                _draggableObject.transform.parent = gameObject.transform;

                IsCarrying = true;
            }
        }
        else
        {
            if (_draggableObject != null)
            {
                _draggableObject.GetComponent<BoxCollider>().enabled = true;

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
