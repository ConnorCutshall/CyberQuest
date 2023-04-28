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
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Bridge") && getsKilled())
        {
            Destroy(this.gameObject);
        }
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
