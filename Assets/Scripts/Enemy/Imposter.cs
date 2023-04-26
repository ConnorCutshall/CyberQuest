using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imposter : MonoBehaviour
{
    public int maxHealth = 30;
    public int health = 30;

    public int dataDamage = 5;
    public GameObject upgrades;
    public UpgradeData upgradeData;

    public void Start()
    {
        if (upgradeData.EducationLevel > 0) 
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
        if (collision.gameObject.CompareTag("Bridge"))
        {
            TakeDamage(maxHealth * 2);
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
