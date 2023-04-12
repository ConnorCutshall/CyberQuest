using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Peasant : MonoBehaviour
{
    public int maxHealth = 20;
    public int health = 20;

    public int dataDamage = 1;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire Wall")) 
        {
            TakeDamage(maxHealth);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            StealCastleData(collision);
            TakeDamage(maxHealth);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
            TakeDamage(maxHealth);
        }
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(Wait(2));
            this.GetComponent<CapsuleCollider2D>().enabled= false;
            StartCoroutine(Wait(1));
            this.GetComponent<CapsuleCollider2D>().enabled = true;
        }
        if (collision.gameObject.CompareTag("Ambush Wall"))
        {
            StartCoroutine(Wait(2));
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            StartCoroutine(Wait(1));
            this.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
    public void TakeDamage(int damage)
    {
        this.health -= damage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void StealCastleData(Collision2D collision) 
    {
        collision.gameObject.transform.parent.GetComponent<Castle>().data -= dataDamage;
    }
    IEnumerator Wait(int t)
    {
        yield return new WaitForSeconds(t);
    }
}
