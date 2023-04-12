using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caravan : MonoBehaviour
{
    public int data;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Castle"))
        {
            GiveCastleData(collision);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("VPN"))
        {
            Destroy(this.gameObject);
        }
    }
    public void GiveCastleData(Collision2D collision)
    {
        collision.gameObject.transform.parent.GetComponent<Castle>().data += data;
    }
}
