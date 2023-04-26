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
        if (Input.GetKey("q"))
        {
            //cam.GetComponent<CinemachineVirtualCamera>();
        }
        else 
        { 

        }

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
        if (collision.gameObject.CompareTag("Peasant"))
        {
            if (collision.gameObject.GetComponent<Peasant>())
            {
                if (collision.gameObject.GetComponent<Peasant>().TakeDamage(damage))
                {
                    upgradeData.playerMoney += Random.Range(5, 15);
                }
            }
            else 
            {
                if (collision.gameObject.GetComponent<Imposter>().TakeDamage(damage))
                {
                    upgradeData.playerMoney += Random.Range(10, 20);
                }
            }

            
        }
    }
}
