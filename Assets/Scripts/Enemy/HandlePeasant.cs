using JetBrains.Annotations;
using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePeasant : MonoBehaviour
{
    public Vector2 northSpawn = new Vector2(3, 95);
    public Vector2 eastSpawn = new Vector2(63, 33);
    public Vector2 southSpawn = new Vector2(3, -15);
    public Vector2 westSpawn = new Vector2(-50, 33);

    public GameObject peasantPrefab;
    public GameObject Upgrades;

    public GameObject northNode;
    public GameObject eastNode;
    public GameObject southNode;
    public GameObject westNode;
    public GameObject castleNode;

    public GameObject FakeCastleSW;
    public GameObject FakeCastleSE;
    public GameObject FakeCastleNE;
    public GameObject FakeCastleNW;
    public void HandlePeasants()
    {
        //spawn north
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = northSpawn + new Vector2(Random.Range(-30.0f, 30.0f), Random.Range(-10.0f, 10.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;

            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = GetRandomCaslte(1);
            }
            else 
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = castleNode.transform;
            }
            
        }

        //spawn east
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = eastSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;

            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = GetRandomCaslte(2);
            }
            else
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = castleNode.transform;
            }
        }

        //spawn south
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = southSpawn + new Vector2(Random.Range(-30.0f, 30.0f), Random.Range(-10.0f, 10.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;

            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = GetRandomCaslte(3);
            }
            else
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = castleNode.transform;
            }
        }

        // spawn west
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = westSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;

            if (Upgrades.GetComponent<HandleUpgrades>().hasVPN)
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = GetRandomCaslte(4);
            }
            else
            {
                CurrPeasant.GetComponent<AIDestinationSetter>().target = castleNode.transform;
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
