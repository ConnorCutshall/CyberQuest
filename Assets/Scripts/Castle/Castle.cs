using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public int data = 100;
    public int backups = 2;

    public GameObject gameController;
    public GameStateData gamestate;

    public void Start()
    {
        data = gamestate.castleData;
    }

    public void Update()
    {
        gamestate.castleData= data;
        if (data <= 0) 
        { 
            GameOver();
        }
    }

    public void GameOver() 
    {
        gameController.GetComponent<GameController>().GameOver();
    }
}
