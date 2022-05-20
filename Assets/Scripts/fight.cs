using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fight : MonoBehaviour
{
	
	public Animator Animator;
	
	private int Chooser = 0;
	
	public bool kick = false;
	public bool punch = false;
	public bool block = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
		if(Input.GetButtonDown("Fire1")){
			
			punch = true;
			StartCoroutine(punch_off());
			Chooser = Random.Range(0,2);
			if(Chooser == 1){
			   Animator.SetTrigger("punch_left");
			}
			else{
				Animator.SetTrigger("punch_right");
			}
		}
		
		if(Input.GetButtonUp("Fire1")){
			//punch = false;
		}
		
		
		
		if(Input.GetButtonDown("Fire2")){
			
			kick = true;
			StartCoroutine(kick_off());
			Chooser = Random.Range(0,2);
			if(Chooser == 1){
			   Animator.SetTrigger("kick_left");
			}
			else{
				Animator.SetTrigger("kick_right");
			}
		}
		
		if(Input.GetButtonUp("Fire2")){
			//kick = false;
		}
		
		if(Input.GetButtonDown("Fire3")){
			Animator.SetBool("block", true);
			block = true;
		}
		
		if(Input.GetButtonUp("Fire3")){
			Animator.SetBool("block", false);
			block = false;
		}
        
    }
	
	IEnumerator kick_off(){
		yield return new WaitForSeconds(1f);
		Debug.Log("potku lopetettiin");
		kick = false;
		
	}
	
	IEnumerator punch_off(){
		yield return new WaitForSeconds(1f);
		Debug.Log("lyönti lopetettiin");
		kick = false;
		
	}
}












