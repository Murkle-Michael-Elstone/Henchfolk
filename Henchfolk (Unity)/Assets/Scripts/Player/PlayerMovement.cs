using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	// Friction
	private float groundedIdleFriction = 1f;
	private float groundedMovingFriction = 0f;
	private float AirborneFriction = 0f;
	public CircleCollider2D feetHitbox;


	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}

		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}
		else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}

		// Handle player lower friction
		/*if (horizontalMove == 0f)
        {
			Debug.Log("Not Moving");
			feetHitbox.sharedMaterial.friction = groundedIdleFriction;
		}
		else if (horizontalMove != 0f)
        {
			Debug.Log("Moving");
			feetHitbox.sharedMaterial.friction = groundedMovingFriction;
        }
		*/
		//Debug.Log(horizontalMove);

	}

	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;

	}
}