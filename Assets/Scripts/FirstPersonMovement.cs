using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
	private CharacterController controller;
    private Vector3 velocity;
	
	public Transform groundCheck;
	public LayerMask groundMask;
	
    public float speed = 30.0f;
	public float jumpHeight = 30.0f;
	public float gravityMultiplier = 1.0f;
    private float gravity = -9.81f;
	//private float groundDistance = 1.0f;
    private bool isGrounded;
	public float speedRate = 2.0f;
	
	void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	
    void Update()
    {
		if(EscMenu.paused){ return; }
		float left_right = Input.GetAxis("Horizontal");
		float forward_back = Input.GetAxis("Vertical");
		
		//Move player with wasd or arrow keys based on facing direction
        Vector3 move = 	transform.forward * forward_back * speed +
						transform.right   * left_right * speed;
		
		//give player ability to move a bit faster
		if (Input.GetKey(KeyCode.X)) {

			controller.Move(move * speedRate * Time.deltaTime);
		}
		else
		{
			controller.Move(move * Time.deltaTime);
		}
		
		//Check if Grounded and playerVeclocity is 0 then stay on Ground;
		//isGrounded = controller.isGrounded;
		//isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
		isGrounded = Physics.CheckBox(groundCheck.position, groundCheck.localScale, groundCheck.localRotation, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }
		
        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity * gravityMultiplier);
        }


        velocity.y += gravity * gravityMultiplier * Time.deltaTime;
		//position 		= p_0 + v * t + 1/2 * a * t^2
		//velocity 		= v0 + at
		//acceleration  = gravity
			
        controller.Move(velocity * Time.deltaTime);
    }
}
