using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caravan : MonoBehaviour
{
    public int data;

    public GameObject Upgrades;
    public GameObject Attacks;
    public GameObject PassagePoint;
    public GameObject ExitPoint;
    public GameObject TrickPoint;
    public GameObject CastlePoint;

    public UpgradeData upgradeData;
    public void Start()
    {
        UpdateTarget();
    }
    public void UpdateTarget() 
    {

        if (upgradeData.EncryptionLevel > 0)
        {
            this.GetComponent<AIDestinationSetter>().target = PassagePoint.transform;
        }
        else if (Attacks.GetComponent<HandleAttacks>().hasTrickster &&
                upgradeData.VPNLevel <= 0) 
        {
            this.GetComponent<AIDestinationSetter>().target = TrickPoint.transform;
        }
        else
        {
            this.GetComponent<AIDestinationSetter>().target = CastlePoint.transform;
        }

    }
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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Passage"))
        {
            this.transform.position = ExitPoint.transform.position;
            this.GetComponent<AIDestinationSetter>().target = CastlePoint.transform;
        }
        if (collision.gameObject.CompareTag("Trickster"))
        {
            Destroy(this.gameObject);
        }
    }
    public void GiveCastleData(Collision2D collision)
    {
        collision.gameObject.transform.parent.GetComponent<Castle>().data += data;
    }
}
