using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Transform player;

    Vector2 playerRotation;

    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0f, 0f, Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime);

        playerRotation.x += Input.GetAxis("Mouse X");
        player.localRotation = Quaternion.Euler(0f, playerRotation.x, 0f);
        
        // Animations
        playerAnim.SetFloat("PlayerRunning", Input.GetAxisRaw("Vertical"));
        
    }
}
