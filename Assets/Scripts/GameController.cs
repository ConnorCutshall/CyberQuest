using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverUI;

    public void GameOver() 
    {
        gameOverUI.transform.parent.gameObject.SetActive(true);
        gameOverUI.SetActive(true);
        Time.timeScale= 0.0f;
    }
}
