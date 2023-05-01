using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleRobot : MonoBehaviour
{
    public int numPeasantPerWave = 20;

    public Vector2 northSpawn = new Vector2(3, 95);
    public Vector2 eastSpawn = new Vector2(63, 33);
    public Vector2 southSpawn = new Vector2(3, -15);
    public Vector2 westSpawn = new Vector2(-50, 33);

    public GameObject robotPrefab;
    public GameObject Upgrades;

    public GameObject castleNode;

    public UpgradeData upgradeData;


    public AttackData attackData;
    public void HandleRobots()
    {
        //spawn north
        for (int i = 0; i < numPeasantPerWave; i++)
        {
            Vector2 spawnPosition = northSpawn + new Vector2(Random.Range(-30.0f, 30.0f), Random.Range(-10.0f, 10.0f));

            GameObject CurrRobot = Instantiate(robotPrefab);
            CurrRobot.transform.position = spawnPosition;
            CurrRobot.transform.parent = this.transform;

            HandleAltUpgrades(CurrRobot, 1);

            attackData.EnemyList.Add(CurrRobot);
        }

        //spawn east
        for (int i = 0; i < numPeasantPerWave; i++)
        {
            Vector2 spawnPosition = eastSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrRobot = Instantiate(robotPrefab);
            CurrRobot.transform.position = spawnPosition;
            CurrRobot.transform.parent = this.transform;

            HandleAltUpgrades(CurrRobot, 2);
            attackData.EnemyList.Add(CurrRobot);
        }

        //spawn south
        for (int i = 0; i < numPeasantPerWave; i++)
        {
            Vector2 spawnPosition = southSpawn + new Vector2(Random.Range(-30.0f, 30.0f), Random.Range(-10.0f, 10.0f));

            GameObject CurrRobot = Instantiate(robotPrefab);
            CurrRobot.transform.position = spawnPosition;
            CurrRobot.transform.parent = this.transform;

            HandleAltUpgrades(CurrRobot, 3);
            attackData.EnemyList.Add(CurrRobot);
        }

        // spawn west
        for (int i = 0; i < numPeasantPerWave; i++)
        {
            Vector2 spawnPosition = westSpawn + new Vector2(Random.Range(-10.0f, 10.0f), Random.Range(-30.0f, 30.0f));

            GameObject CurrRobot = Instantiate(robotPrefab);
            CurrRobot.transform.position = spawnPosition;
            CurrRobot.transform.parent = this.transform;

            HandleAltUpgrades(CurrRobot, 4);
            attackData.EnemyList.Add(CurrRobot);
        }
    }
    public void HandleAltUpgrades(GameObject currRobot, int dirIndex)
    {

        currRobot.GetComponent<AIDestinationSetter>().target = castleNode.transform;
        if (upgradeData.EducationLevel > 0)
        {
            Upgrades.GetComponent<HandleUpgrades>().Education.GetComponent<HandleGuard>().enemeyList.Add(currRobot);
        }
    }
    


    public static bool getsKilled(int chanceOfDeath = 80)
    {
        int roll = Random.Range(0, 100) + 1;
        if (roll < chanceOfDeath)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
