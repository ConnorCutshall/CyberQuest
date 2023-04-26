using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleImposter : MonoBehaviour
{
    public GameObject CastleNode;

    public List<GameObject> spawnLocations;

    public GameObject imposterPrefab;
    public GameObject upgrades;
    public UpgradeData upgradeData;

    public void HandleImposters() 
    {
        for (int i = 0; i < spawnLocations.Count; i++)
        {
            GameObject CurrImposter = Instantiate(imposterPrefab);
            CurrImposter.transform.position = spawnLocations[i].transform.position;
            CurrImposter.transform.parent = this.transform;
            CurrImposter.GetComponent<Imposter>().upgradeData= upgradeData;
            CurrImposter.GetComponent<Imposter>().upgrades = upgrades;
            CurrImposter.GetComponent<AIDestinationSetter>().target = CastleNode.transform;
        }
    }
}
