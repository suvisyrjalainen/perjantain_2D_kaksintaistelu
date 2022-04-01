using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	private float horizontalSpeed = 0f;
	
	public float speed = 5f;
	public float JumpForce = 7.5f;
	
	public CircleCollider2D Feet;
	
	//Rigidbody for movement
    public Rigidbody2D MyRigidbody2D;
	
	public Animator Animator;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//Ottaa talteen paljonko vaakanäppäimiä on painettu
        horizontalSpeed = Input.GetAxis("Horizontal");
		
		if(Input.GetButtonDown("Jump") && Feet.IsTouchingLayers(LayerMask.GetMask("Ground"))){
			MyRigidbody2D.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
			Animator.SetTrigger("jump");
		}
		
		Animator.SetFloat("walk", Mathf.Abs(horizontalSpeed));
		
		//Tämä komento liikuttaa näppäinpainallusten verran
		MyRigidbody2D.velocity = new Vector2(horizontalSpeed * speed, MyRigidbody2D.velocity.y);
		
		
		if(Feet.IsTouchingLayers(LayerMask.GetMask("Ground"))){
			Animator.SetBool("is_grounded", true);
		}
		else{
			Animator.SetBool("is_grounded", false);
		}
		
		if(Input.GetButtonDown("Fire1")){
			Animator.SetTrigger("punch_left");
		}
		
		
    }
}
