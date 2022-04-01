using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public float MaxHealth = 100f;
    public float Health;
    private float HitTimer = 0.15f;
    public bool IsHit = false;
    public Rigidbody2D MyRigidbody2D;
    public Animator Animator;


    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float Damage)
    {
        if(!IsHit)
        {
            Health -= Damage;
            //StartCoroutine(Knockback());
        }
    }

    /*
    IEnumerator Knockback()
    {
        IsHit = true;
        MyRigidbody2D.velocity = new Vector2((GetComponent<player>().Facing * 2.5f), 2.5f);
        Animator.SetTrigger("TakeDamage");
        yield return new WaitForSeconds(HitTimer);
        IsHit = false;
    }
	*/

    void Die()
    {
        Animator.SetTrigger("Die");
        StartCoroutine(Dying());
    }

    IEnumerator Dying()
    {
        IsHit = true;
        MyRigidbody2D.velocity = new Vector2(0f, MyRigidbody2D.velocity.y);
        yield return new WaitForSeconds(5f);
    }

}
