using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public CharacterController playerController;

    public Transform player;

    public Transform playerCam;

    public float turnSmoothing = 0.1f;

    float turnVelocity;

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
        float playerX = Input.GetAxis("Horizontal");
        float playerZ = Input.GetAxis("Vertical");

        Vector3 playerMovement = new Vector3(playerX,0f,playerZ).normalized;
        
        if(playerMovement.magnitude >= 0.1f)
        {
            // This ensures the player faces the direction it is moving in.
            float playerDirection = Mathf.Atan2(playerMovement.x, playerMovement.z) * Mathf.Rad2Deg + playerCam.eulerAngles.y;
            float turnDamping = Mathf.SmoothDampAngle(transform.eulerAngles.y, playerDirection, ref turnVelocity, turnSmoothing);
            transform.rotation = Quaternion.Euler(0f, turnDamping, 0f);

            // This then makes the player move in the direction it is facing.
            Vector3 moveInDirection = Quaternion.Euler(0f, playerDirection, 0f) * Vector3.forward;

            playerController.Move(moveInDirection.normalized * playerSpeed * Time.deltaTime);

            // This allows for the running animation to be played when the player is moving forward.
            playerAnim.SetFloat("Vertical", Input.GetAxis("Vertical"));
        }
        
    }
}
