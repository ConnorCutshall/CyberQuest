using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public int maxHealth = 20;
    public int health = 20;

    public int dataDamage = 3;
    public GameObject Target;

    public void Update()
    {
        if (Target == null)
        {
            Destroy(this.gameObject);
        }
    }

    public void StealData(Collision2D collision)
    {
        collision.gameObject.transform.GetComponent<Caravan>().data -= dataDamage;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Caravan"))
        {
            StealData(collision);
            TakeDamage(maxHealth);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
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
    IEnumerator Wait(int t)
    {
        yield return new WaitForSeconds(t);
    }
}
