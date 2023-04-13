using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

    public void HandleThieves() 
    {
        for (int i = 0; i < spawnLocations.Count; i++) 
        {
            GameObject CurrThief = Instantiate(thiefPrefab);
            CurrThief.transform.position = spawnLocations[i].transform.position;
            CurrThief.transform.parent = this.transform;

            //upgrade exceptions
            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                GameObject target = GetRandomCaslte(spawnLocations[i].GetComponent<AmbushInfo>().cardinalDirNum);
                CurrThief.GetComponent<AIDestinationSetter>().target = target.transform;
                CurrThief.GetComponent<Thief>().Target = target;
            }
            else
            {
                CurrThief.GetComponent<AIDestinationSetter>().target = spawnLocations[i].GetComponent<AmbushInfo>().toAmbush.transform;
                CurrThief.GetComponent<Thief>().Target = spawnLocations[i].GetComponent<AmbushInfo>().toAmbush;
            }

            if (Upgrades.GetComponent<HandleUpgrades>().hasEducation)
            {
                Upgrades.GetComponent<HandleUpgrades>().Education.GetComponent<HandleGuard>().enemeyList.Add(CurrThief);
            }

        }
    }
    public GameObject GetRandomCaslte(int dirNum)
    {
        int rand;
        switch (dirNum)
        {
            case 1:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleNE;
                }
                if (rand == 1)
                {
                    return FakeCastleNW;
                }
                break;
            case 2:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleNE;
                }
                if (rand == 1)
                {
                    return FakeCastleSE;
                }
                break;
            case 3:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleSE;
                }
                if (rand == 1)
                {
                    return FakeCastleSW;
                }
                break;
            case 4:
                rand = (int)Random.Range(0, 2);
                if (rand == 0)
                {
                    return FakeCastleSW;
                }
                if (rand == 1)
                {
                    return FakeCastleNW;
                }
                break;
        }

        return castleNode;
    }
}
