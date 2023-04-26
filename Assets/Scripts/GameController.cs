using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Profiling;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject handleAttacks;
    public UpgradeData upgradeData;
    public GameStateData gameStateData;

    public float roundTime;
    public float seconds;
    public float secondsPerRound;

    public bool allUnlocked;

    private int roundNum;


    public void Update()
    {
        roundTime += Time.deltaTime;
        seconds = Mathf.FloorToInt(roundTime) - secondsPerRound * roundNum;
        if (seconds > secondsPerRound) 
        {
            roundNum++;
            gameStateData.roundNum++;
            HandleRound(gameStateData.roundNum);
            handleAttacks.GetComponent<HandleAttacks>().Attacks(gameStateData.roundNum);
        }
    }
    public void HandleRound(int i)
    {
        int[] upgrades = upgradeData.upgrades;
        // i is the round number
        // Advances to Tier 2 and 3
        if (i == 3)
        {
            upgrades[3] = -1;
            upgrades[4] = -1;
            upgrades[5] = -1;

            upgradeData.VPNLevel = -1;
            upgradeData.TwoFactorLevel = -1;
            upgradeData.BackupLevel = -1;
        }
        if (i == 6)
        {
            upgrades[6] = -1;
            upgrades[7] = -1;
            upgrades[8] = -1;

            upgradeData.EducationLevel= -1;
            upgradeData.PlayerSpeedLevel = -1;
            upgradeData.PlayerAttackLevel= -1;
        }


        //check to see if all unlocked
        allUnlocked = true;
        for (int j = 0; j < upgrades.Length; j++) 
        {
            if (upgrades[j] == -1) 
            {
                allUnlocked = false;
            }
        }

        int tempUp;
        if (!allUnlocked) //unlock if not all unlocked
        {
            tempUp = getUnlock(upgrades); // Figures out which upgrade to unlock
            upgrades[tempUp] = 0; // Unlocks the upgrade
        }
        else 
        {
            tempUp = -1;
        }


        //Updates Scriprabel Obj
        upgradeData.upgrades = upgrades;

        // Outputs the upgrade selected each round
        switch (tempUp)
        {
            case 0:
                //System.out.println("Encryption");

                Debug.Log("Encryption");
                upgradeData.EncrytpionLevel= 0;
                break;
            case 1:
                //System.out.println("Firewalls");
                Debug.Log("Firewalls");
                upgradeData.FireWallLevel= 0;
                break;
            case 2:
                //System.out.println("Segmentation");
                Debug.Log("Segmentation");
                upgradeData.SegmentationLevel= 0;
                break;
            case 3:
                //System.out.println("VPN");
                upgradeData.VPNLevel= 0;
                Debug.Log("VPN");
                break;
            case 4:
                //System.out.println("Auth");
                Debug.Log("Auth");
                upgradeData.TwoFactorLevel = 0;
                break;
            case 5:
                //System.out.println("Backups");
                Debug.Log("Backups");
                upgradeData.BackupLevel= 0;
                break;
            case 6:
                //System.out.println("Education");
                Debug.Log("Education");
                upgradeData.EducationLevel = 0;
                break;
            case 7:
                //System.out.println("Attack Speed");
                Debug.Log("Attack Speed");
                upgradeData.PlayerAttackLevel= 0;
                break;
            case 8:
                //System.out.println("Movement Speed");
                Debug.Log("Movement Speed");
                upgradeData.PlayerSpeedLevel= 0;
                break;
        }
        
    }

    public int getUnlock(int[] upgrades)
    {
        int index;

        while (true)
        {
            // Generates random number
            index = Random.Range(0, upgrades.Length);
            // Re-rolls if it's a rare technology
            if ((index + 1) % 3 == 0)
            {
                index = Random.Range(0, upgrades.Length);
            }

            // Check if it's valid
            if (upgrades[index] == -1)
            {
                // FOLLOWING TWO LINES HANDLE WHICH UPGRADE TO UNLOCK
                return index;
            }
        }
    }


    public void GameOver() 
    {
        gameOverUI.transform.parent.gameObject.SetActive(true);
        gameOverUI.SetActive(true);
        Time.timeScale= 0.0f;
    }
}
