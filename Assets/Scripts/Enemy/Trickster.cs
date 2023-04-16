using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trickster : MonoBehaviour
{
    public int maxHealth = 20;
    public int health = 20;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire Wall"))
        {
            TakeDamage(maxHealth / 2);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
            TakeDamage(maxHealth / 2);
        }
    }

    public void TakeDamage(int damage)
    {
        int exactDamage = Random.Range(damage - 3, damage + 3);
        if (exactDamage <= 0)
        {
            exactDamage = 1;
        }

        this.health -= exactDamage;
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
