using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleThief : MonoBehaviour
{
    public GameObject thiefPrefab;
    public GameObject Upgrades;

    public GameObject FakeCastleSW;
    public GameObject FakeCastleSE;
    public GameObject FakeCastleNE;
    public GameObject FakeCastleNW;

    public GameObject castleNode;

    public List<GameObject> spawnLocations;

    public void HandleThiefs() 
    {
        for (int i = 0; i < spawnLocations.Count; i++) 
        {
            GameObject CurrThief = Instantiate(thiefPrefab);
            CurrThief.transform.position = spawnLocations[i].transform.position;
            CurrThief.transform.parent = this.transform;
            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                CurrThief.GetComponent<AIDestinationSetter>().target = GetRandomCaslte(spawnLocations[i].GetComponent<AmbushInfo>().cardinalDirNum);
            }
            else
            {
                CurrThief.GetComponent<AIDestinationSetter>().target = spawnLocations[i].GetComponent<AmbushInfo>().toAmbush.transform;
            }
            
        }
    }
    public Transform GetRandomCaslte(int dirNum)
    {
        int rand;
        switch (dirNum)
        {
            case 1:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleNE.transform;
                }
                if (rand == 1)
                {
                    return FakeCastleNW.transform;
                }
                break;
            case 2:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleNE.transform;
                }
                if (rand == 1)
                {
                    return FakeCastleSE.transform;
                }
                break;
            case 3:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleSE.transform;
                }
                if (rand == 1)
                {
                    return FakeCastleSW.transform;
                }
                break;
            case 4:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleSW.transform;
                }
                if (rand == 1)
                {
                    return FakeCastleNW.transform;
                }
                break;
        }

        return castleNode.transform;
    }
}
