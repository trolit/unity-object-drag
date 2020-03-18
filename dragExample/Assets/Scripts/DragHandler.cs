using UnityEngine;

public class DragHandler : MonoBehaviour
{
    private GameObject _draggableObject;

    public static bool IsCarrying = false;

    private Vector2 startingPos;

    private Vector2 currentPos;

    private GameObject tmp;

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
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            if (_draggableObject != null)
            {
                tmp = _draggableObject;

                _draggableObject.GetComponent<Rigidbody>().isKinematic = false;

                var rigidbody = _draggableObject.GetComponent<Rigidbody>();
                rigidbody.angularVelocity = Vector3.zero;

                //if (gameObject.transform.rotation.y >= -90)
                //{
                //    rigidbody.velocity += Vector3.up * Physics.gravity.y * Time.deltaTime;
                //}
                //else if (gameObject.transform.rotation.y == 180)
                //{
                //    _draggableObject.GetComponent<Rigidbody>().AddForce(-transform.forward, ForceMode.VelocityChange);
                //}
                //else if (gameObject.transform.rotation.y == 0)
                //{
                //    _draggableObject.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.VelocityChange);
                //}
                //else if (gameObject.transform.rotation.y >= 90)
                //{
                //    _draggableObject.GetComponent<Rigidbody>().AddForce(transform.right, ForceMode.VelocityChange);
                //}

                // rigidbody.velocity += Vector3.down * Physics.gravity.y * 555 * Time.deltaTime;

                _draggableObject.GetComponent<Rigidbody>().AddForce(transform.forward, ForceMode.Impulse);
                Invoke("ReturnIsKinematic", 5f);
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

            startingPos = block.gameObject.transform.position;
        }
    }
    
    private void ReturnIsKinematic()
    {
        tmp.GetComponent<Rigidbody>().isKinematic = true;
    }
}
