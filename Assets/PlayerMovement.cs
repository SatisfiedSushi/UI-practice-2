using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public CharacterController controller;

	public float speed = 12f;
	public float gravity = -9.81f;
	public float jumpHeight = 3f;

	public Transform groundCheck;
	public float groundDistance = 0.4f;
	public LayerMask groundMask;

	Vector3 velocity;
	bool isGrounded;

	//timer variables
	public float coolDownTimer;

	private float coolDown = 10;

	public float abilityTimer;

	public float abilityTimerHolder = 1;
	// Update is called once per frame
	void Update()
	{
		isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		Vector3 move = transform.right * x + transform.forward * z;


		controller.Move(move * speed * Time.deltaTime);

		if (Input.GetKey("space") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
		}
		velocity.y += gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);

		if (coolDownTimer > 0)
		{
			coolDownTimer -= Time.deltaTime;
		}
		
		if (coolDownTimer < 0)
        {
			coolDownTimer = 0;
        }

		if (Input.GetKeyDown("v") && coolDownTimer == 0)
        {
			Debug.Log("hi");
			Dash();
			coolDownTimer = coolDown;
			speed = 100f;
		}

		if (coolDownTimer <= 8)
		{

			speed = 8f;

		}

	}

	private void Dash()
	{
		
		
		

		
	}


}