using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleThief : MonoBehaviour
{
    public GameObject thiefPrefab;

    public List<GameObject> spawnLocations;

    public void HandleThiefs() 
    {
        for (int i = 0; i < spawnLocations.Count; i++) 
        {
            GameObject CurrThief = Instantiate(thiefPrefab);
            CurrThief.transform.position = spawnLocations[i].transform.position;
            CurrThief.transform.parent = this.transform;
            CurrThief.GetComponent<AIDestinationSetter>().target = spawnLocations[i].GetComponent<AmbushInfo>().toAmbush.transform;
        }
    }
}
