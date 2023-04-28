using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cam;

    public int damage = 10000;

    public UpgradeData upgradeData;
    public GameObject UI;
    public bool uiEnabled;
    void Start()
    {
        uiEnabled = false;
        UI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && !uiEnabled)
        {
            uiEnabled = true;
            UI.SetActive(true);
        }
        else if (Input.GetKeyDown("e") && uiEnabled)
        {
            uiEnabled = false;
            UI.SetActive(false);
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Peasant") || collision.CompareTag("Thief") || collision.CompareTag("Trickster"))
        {
            Destroy(collision.gameObject);
        }
    }
}
