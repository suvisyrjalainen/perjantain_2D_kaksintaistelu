using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catHealth : MonoBehaviour
{
	public float MaxHealth = 100f;
    public float Health;
	
    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Törmäsin vastustajaan");
			Health -= 10;
			Debug.Log(Health);
        }
    }
}
