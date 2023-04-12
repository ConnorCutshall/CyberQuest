using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    public int maxHealth = 20;
    public int health = 20;

    public int dataDamage = 1;
    public void StealCastleData(Collision2D collision)
    {
        collision.gameObject.transform.parent.GetComponent<Castle>().data -= dataDamage;
    }
    
    IEnumerator Wait(int t)
    {
        yield return new WaitForSeconds(t);
    }
}
