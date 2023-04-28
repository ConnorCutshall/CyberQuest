using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trickster : MonoBehaviour
{
    public int maxHealth = 20;
    public int health = 20;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire Wall") && getsKilled())
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
            Destroy(this.gameObject);
        }
    }

    public static bool getsKilled(int chanceOfDeath = 80)
    {
        int roll = Random.Range(0, 100) + 1;
        if (roll < chanceOfDeath)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
