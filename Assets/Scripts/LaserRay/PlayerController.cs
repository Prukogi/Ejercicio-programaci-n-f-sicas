using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;
	[SerializeField] private float jumpForce = 5f;
	[SerializeField] private bool isGrounded = true;
	
	private bool jump = false;
	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
	private void Update()
	{


		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
			jump = true;
	}
    void FixedUpdate()
    {
		//Player Movement
        if (Input.GetKey(KeyCode.W)) 
            rb.AddForce(Vector3.forward * moveSpeed);
        
		if (Input.GetKey(KeyCode.S))
			rb.AddForce(Vector3.back * moveSpeed);
        
		if (Input.GetKey(KeyCode.D))
			rb.AddForce(Vector3.right * moveSpeed);
		
		if (Input.GetKey(KeyCode.A))
			rb.AddForce(Vector3.left * moveSpeed);

		//Player Jump
		if (jump)
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			isGrounded = false;
			jump = false;
		}
	}



	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
			isGrounded = true;
	}



	private void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground")) 
			isGrounded = false;
	}

	





}



	













	
	




   
