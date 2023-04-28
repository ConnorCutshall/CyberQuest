using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject handleAttacks;
    public UpgradeData upgradeData;
    public GameStateData gameStateData;
    public AttackData attackData;

    public GameObject teleportEffect;

    public float roundTime;
    public float seconds;
    public float secondsPerRound;

    public bool allUnlocked;

    private int roundNum;

    public void Start()
    {
        handleAttacks.GetComponent<HandleAttacks>().Attacks(gameStateData.roundNum);
    }
    public void Update()
    {

        seconds = Mathf.FloorToInt(roundTime) - secondsPerRound * roundNum;
        //if (seconds > secondsPerRound) 
        //{
        //    roundNum++;
        //    gameStateData.roundNum++;
        //    HandleRound(gameStateData.roundNum);
        //    handleAttacks.GetComponent<HandleAttacks>().Attacks(gameStateData.roundNum);
        //    upgradeData.playerMoney += 150;
        //}
        if (attackData.EnemyList.Count == 0)
        {
            //wait for three seconds then next round
            roundTime += Time.deltaTime;
        }
        if (roundTime > 2) 
        {
            teleportEffect.SetActive(true); 
        }
        if (roundTime > 3)
        {
            roundNum++;
            gameStateData.roundNum++;
            upgradeData.playerMoney += 150;
            roundTime = 0;
            teleportEffect.SetActive(false);
            SceneManager.LoadScene(2);

        }
        for (int i = 0; i < attackData.EnemyList.Count; i++)
        {
            if (attackData.EnemyList[i] == null ) 
            {
                attackData.EnemyList.RemoveAt(i);
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
