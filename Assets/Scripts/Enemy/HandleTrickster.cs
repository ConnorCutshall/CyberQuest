using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTrickster : MonoBehaviour
{
    public GameObject tricksterPrefab;
    public GameObject Upgrades;

    public GameObject tricksterEnd1;
    public GameObject tricksterEnd2;
    public GameObject tricksterEnd3;
    public GameObject tricksterEnd4;

    public GameObject tricksterStart1;
    public GameObject tricksterStart2;
    public GameObject tricksterStart3;
    public GameObject tricksterStart4;

    public GameObject FakeCastleSW;
    public GameObject FakeCastleSE;
    public GameObject FakeCastleNE;
    public GameObject FakeCastleNW;

    public UpgradeData upgradeData;
    public void HandleTricksters()
    {
        GameObject trick1 = Instantiate(tricksterPrefab);
        trick1.transform.position = tricksterStart1.transform.position;
        trick1.transform.parent = this.transform;
        if (upgradeData.VPNLevel > 0)
        {
            trick1.GetComponent<AIDestinationSetter>().target = FakeCastleSW.transform;
        }
        else
        {
            trick1.GetComponent<AIDestinationSetter>().target = tricksterEnd1.transform; ;
        }

        trick1 = Instantiate(tricksterPrefab);
        trick1.transform.position = tricksterStart2.transform.position;
        trick1.transform.parent = this.transform;
        if (upgradeData.VPNLevel > 0)
        {
            trick1.GetComponent<AIDestinationSetter>().target = FakeCastleSE.transform;
        }
        else
        {
            trick1.GetComponent<AIDestinationSetter>().target = tricksterEnd2.transform;
        }


        trick1 = Instantiate(tricksterPrefab);
        trick1.transform.position = tricksterStart3.transform.position;
        trick1.transform.parent = this.transform;
        if (upgradeData.VPNLevel > 0)
        {
            trick1.GetComponent<AIDestinationSetter>().target = FakeCastleNE.transform;
        }
        else
        {
            trick1.GetComponent<AIDestinationSetter>().target = tricksterEnd3.transform;
        }


        trick1 = Instantiate(tricksterPrefab);
        trick1.transform.position = tricksterStart4.transform.position;
        trick1.transform.parent = this.transform;
        if (upgradeData.VPNLevel > 0)
        {
            trick1.GetComponent<AIDestinationSetter>().target = FakeCastleNW.transform;
        }
        else
        {
            trick1.GetComponent<AIDestinationSetter>().target = tricksterEnd4.transform; ;
        }

    }
}

