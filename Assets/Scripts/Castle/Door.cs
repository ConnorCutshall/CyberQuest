using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    public int sceneToLoadNum;
    public GameStateData gamestate;

    public int currRoundNum;

    //public void Update()
    //{
    //    if (gamestate.roundNum != currRoundNum) //round changed
    //    {
    //        currRoundNum = gamestate.roundNum;
    //        SceneManager.LoadScene(sceneToLoadNum);
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            SceneManager.LoadScene(sceneToLoadNum);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneToLoadNum);
        }
    }
}
