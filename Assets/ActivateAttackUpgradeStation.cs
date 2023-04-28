using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAttackUpgradeStation : MonoBehaviour
{
    public GameObject UI;
    public GameObject attackList;
    public GameObject sideBar;
    public GameObject chooseUpgrade;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("here");
        UI.SetActive(true);
        attackList.SetActive(true);
        sideBar.SetActive(false);
        chooseUpgrade.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);
        attackList.SetActive(false);
        sideBar.SetActive(true);
        chooseUpgrade.SetActive(true);
    }


}
