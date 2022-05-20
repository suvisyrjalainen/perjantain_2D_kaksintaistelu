using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
	
	public float speed = -5f;
	public float JumpForce = 7.5f;
	
	public CircleCollider2D Feet;
	
	//Rigidbody for movement
    public Rigidbody2D MyRigidbody2D;
	
	public Animator Animator;
	
	public GameObject pelaaja;
	public GameObject vihollinen;
	
	private float distance = 200f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyRigidbody2D.velocity = new Vector2(speed, MyRigidbody2D.velocity.y);
		Animator.SetFloat("Speed", Mathf.Abs(speed));
		
		distance = Vector3.Distance(pelaaja.transform.position, vihollinen.transform.position);
    
		//Debug.Log(distance);
		
		if(distance < 1.1){
			speed = 0;
		}
		else{
			
		
			if(pelaaja.transform.position.x < vihollinen.transform.position.x){
				Flip(1);
				speed = -1;
			}
			else{
			   Flip(-1);
			   speed = 1;
			}
		
		}
			

		
    }
	
	public void Flip(int x)
    {
        transform.localScale = new Vector2(x,transform.localScale.y);
        
    }
	/*
	void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horse")
        {
            
			
        }
    }
	
	
	*/
	
}
