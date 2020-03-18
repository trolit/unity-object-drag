using UnityEngine;

public class DragHandler : MonoBehaviour
{
    private GameObject _draggableObject;

    [SerializeField]
    [Tooltip("Check this to allow extra dragged object rotation.")]
    private bool IsRotational = false;

    public static bool IsCarrying = false;

    private void Start()
    {
        if(IsRotational)
        {
            RotationHandler.IsEnabled = true;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_draggableObject != null)
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

                if (IsRotational)
                {
                    EditSourceObject();
                }
            }

            IsCarrying = false;
        }      
    }

    private void OnCollisionStay(Collision block)
    {
        if (block.gameObject.CompareTag("Draggable") & IsCarrying == false)
        {
            _draggableObject = block.gameObject;

            if(IsRotational)
            {
                EditSourceObject();
            }
        }
    }

    private void EditSourceObject()
    {
        var test = RotationHandler.source;

        if(test == null)
        {
            RotationHandler.source = _draggableObject;
        }
        else
        {
            RotationHandler.source = null;
        }
    }
}
