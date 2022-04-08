using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    float sensitivity = 300f;

    public Transform player;

    public float mouseXRot = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; // Locks mouse pointer to the centre of the screen.
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        mouseXRot -= mouseY;
        mouseXRot = Mathf.Clamp(mouseXRot, -90f, 90f); // This clamps the mouse look on the y-axis, player can not look up or down past 90 degrees.


        transform.localRotation = Quaternion.Euler(mouseXRot, 0f, 0f); // Allows the camera to rotate on the y-axis.
        player.Rotate(Vector3.up * mouseX); // Rotates the camera on the x-axis.
    }
}
