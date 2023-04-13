using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imposter : MonoBehaviour
{
    public int maxHealth = 30;
    public int health = 30;

    public int dataDamage = 5;
    public GameObject upgrades;

    public void Start()
    {
        if (upgrades.GetComponent<HandleUpgrades>().hasEducation) 
        {
            upgrades.GetComponent<HandleUpgrades>().Education.GetComponent<HandleGuard>().enemeyList.Add(this.gameObject);
        }
       
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            StealCastleData(collision);
            TakeDamage(maxHealth * 2);
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
    public void StealCastleData(Collider2D collision)
    {
        collision.gameObject.transform.parent.GetComponent<Castle>().data -= dataDamage;
    }
}
