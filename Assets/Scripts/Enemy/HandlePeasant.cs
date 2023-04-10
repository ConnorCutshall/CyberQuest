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
            CurrPeasant.GetComponent<EnemyPathing>().nextNode = northNode;
            CurrPeasant.GetComponent<EnemyPathing>().castleNode = castleNode;
        }

        //spawn east
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = eastSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;
            CurrPeasant.GetComponent<EnemyPathing>().nextNode = eastNode;
            CurrPeasant.GetComponent<EnemyPathing>().castleNode = castleNode;
        }

        //spawn south
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = southSpawn + new Vector2(Random.Range(-30.0f, 30.0f), Random.Range(-10.0f, 10.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;
            CurrPeasant.GetComponent<EnemyPathing>().nextNode = southNode;
            CurrPeasant.GetComponent<EnemyPathing>().castleNode = castleNode;
        }

        // spawn west
        for (int i = 0; i < 20; i++)
        {
            Vector2 spawnPosition = westSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrPeasant = Instantiate(peasantPrefab);
            CurrPeasant.transform.position = spawnPosition;
            CurrPeasant.transform.parent = this.transform;
            CurrPeasant.GetComponent<EnemyPathing>().nextNode = westNode;
            CurrPeasant.GetComponent<EnemyPathing>().castleNode = castleNode;
        }
    }
}
