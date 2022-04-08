using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
	
	public Animator Animator;
	
	private int Chooser = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if(Input.GetButtonDown("Fire1")){
			
			Chooser = Random.Range(0,2);
			if(Chooser == 1){
			   Animator.SetTrigger("punch_left");
			}
			else{
				Animator.SetTrigger("punch_right");
			}
		}
		
		
		if(Input.GetButtonDown("Fire2")){
			
			Chooser = Random.Range(0,2);
			if(Chooser == 1){
			   Animator.SetTrigger("kick_left");
			}
			else{
				Animator.SetTrigger("kick_right");
			}
		}
		
		if(Input.GetButtonDown("Fire3")){
			Animator.SetBool("block", true);
		}
		
		if(Input.GetButtonUp("Fire3")){
			Animator.SetBool("block", false);
		}
        
    }
}












