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
}
