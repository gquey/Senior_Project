using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private float speedX = 250.0f;
    private float speedY = 100.0f;
	private Vector2 turn;
	public Transform player;
	
	void Start()
	{
		//Locks Mouse Movement onto center of screen
		Cursor.lockState = CursorLockMode.Locked;
	}
    void Update()
    {
		if(EscMenu.paused){ return; }
		//Left and Right Looking
		turn.x = Input.GetAxis("Mouse X") * speedX * Time.deltaTime;
		//Up and down Looking
		turn.y += Input.GetAxis("Mouse Y") * speedY * Time.deltaTime;
		
		//Only look max 15 degrees down and 90 degrees up 
		turn.y = Mathf.Clamp(turn.y, -15f, 90f);
		
		//turn.y is the current value we want to be looking at
		//Quaternion.Euler transforms three rotation points into a point on a sphere
		transform.localRotation = Quaternion.Euler(-turn.y, 0f, 0f);
		
		//turn.x is the relative amount that the mouse has moved in the x direction this frame
		//Rotate takes the current sphere point and adds the given Vector3
		player.Rotate(Vector3.up * turn.x);
    }
}
