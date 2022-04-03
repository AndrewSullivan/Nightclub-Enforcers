using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float playerGravity = -9.81f;

    Vector3 playerVelocity;

    CharacterController playerController;

    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponentInParent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float playerX = Input.GetAxis("Horizontal");
        float playerZ = Input.GetAxis("Vertical");

        Vector3 playerMovement = transform.right * playerX + transform.forward * playerZ;

        playerController.Move(playerMovement * playerSpeed * Time.deltaTime);

        playerVelocity.y += playerGravity * Time.deltaTime;

        playerController.Move(playerVelocity * Time.deltaTime);

        // Animations
        playerAnim.SetFloat("Vertical", playerZ, 0.012f,Time.deltaTime);
        playerAnim.SetFloat("Horizontal", playerX, 0.012f, Time.deltaTime);
        
    }
}