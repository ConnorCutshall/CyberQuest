using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDefenseUpgradeUI : MonoBehaviour
{
    public GameObject UI;
    void OnTriggerEnter2D(Collider2D collision)
    {
        UI.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.SetActive(false);
    }

}
