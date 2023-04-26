using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
        if (collision.gameObject.CompareTag("Castle"))
        {
            StealCastleData(collision);
            TakeDamage(maxHealth * 2);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
            TakeDamage(maxHealth/2);
        }

    }

    public bool TakeDamage(int damage)
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
            return true;
        }
        return false;
    }
    public void StealCastleData(Collider2D collision) 
    {
        if (collision.gameObject.transform.parent != null)
        {
            collision.gameObject.transform.parent.GetComponent<Castle>().data -= dataDamage;
        }
        else
        {
            collision.gameObject.GetComponent<Castle>().data -= dataDamage;
        }
    }

}
