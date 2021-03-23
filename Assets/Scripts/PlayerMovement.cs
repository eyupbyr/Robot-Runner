using UnityEngine;

public class PlayerMovement : Player
{
    Player player;

    private Vector3 moveVector;

    [SerializeField] private float forwardSpeed = default;
    [SerializeField] private float sideSpeed = default;

    private float horizontalInput;

    private float jumpInput;
    [SerializeField] private float jumpHeight = default;
    private float gravity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
    }

    private float temp = 1; //temporary solution, fix this.

    void FixedUpdate()
    {
        runSeconds += Time.deltaTime;
        if (runSeconds / 10 >= temp) {
            temp++;
            forwardSpeed += forwardSpeed * 0.1f; //gets faster as the time passes
        }

        moveVector.z = forwardSpeed; 

        if (player.Controller.isGrounded)
        {
            player.Animator.SetBool("isJumping", false);
            jumpInput = Input.GetAxisRaw("Jump");
            if (jumpInput > 0f)
            {
                player.Animator.SetBool("isJumping", true);
                moveVector.y = jumpHeight * Time.deltaTime;
            }
        }
        else
        {
            moveVector.y -= gravity;
        }

        horizontalInput = Input.GetAxisRaw("Horizontal");
        moveVector.x = horizontalInput * sideSpeed;

        player.Controller.Move(moveVector * Time.deltaTime);
    }
}
