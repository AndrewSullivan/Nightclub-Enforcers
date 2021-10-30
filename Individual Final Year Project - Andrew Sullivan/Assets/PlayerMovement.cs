using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public CharacterController playerController;

    public Transform player;

    public float mouseSensitivity = 500f;

    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Player Keyboard Movement
        float playerX = Input.GetAxis("Horizontal") * playerSpeed;
        float playerZ = Input.GetAxis("Vertical") * playerSpeed;

        Vector3 playerMovement = transform.forward * playerZ + transform.right * playerX;

        playerController.Move(playerMovement * Time.deltaTime);


        // Player Mouse Movement
        float lookX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * lookX);

        playerAnim.SetFloat("Vertical", Input.GetAxis("Vertical"));
    }
}
