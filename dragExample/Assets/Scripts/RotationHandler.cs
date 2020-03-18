using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    public static bool IsEnabled = false;

    public static GameObject source;

    private void Start()
    {
        if (IsEnabled == false)
        {
            enabled = false; // disables the script
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (source != null)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                source.transform.Rotate(0, -90, 0);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                source.transform.Rotate(0, +90, 0);
            }
        }
    }
}
