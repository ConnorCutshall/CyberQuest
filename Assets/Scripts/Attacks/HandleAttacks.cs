using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class HandleAttacks : MonoBehaviour
{
    public bool hasPeasant = true;
    public bool hasThief = true;
    public bool hasTrickster = true;
    public bool hasImposter = true;

    public GameObject peasantHandler;
    public GameObject thiefHandler;
    public GameObject tricksterHandler;
    public GameObject imposterHandler;
    public void Start()
    {

        GetRandAttack();

        if (hasPeasant) 
        {
            peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
        }        
        if (hasThief) 
        {
            thiefHandler.GetComponent<HandleThief>().HandleThieves();
        }
        if (hasTrickster) 
        {
            tricksterHandler.GetComponent<HandleTrickster>().HandleTricksters();
        }
        if (hasImposter)
        {
            imposterHandler.SetActive(true);
        }
        else 
        { 
            imposterHandler.SetActive(false);
        }
        
    }
    public void GetRandAttack()
    {
        if (Random.Range(0, 2) == 1)
        {
            hasPeasant = true;
        }
        else 
        { 
            hasPeasant = false;
        }

        if (Random.Range(0, 2) == 1)
        {
            hasImposter = true;
        }
        else
        {
            hasImposter = false;
        }

        if (Random.Range(0, 2) == 1)
        {
            hasThief = true;
        }
        else
        {
            hasThief = false;
        }


        if (Random.Range(0, 2) == 1)
        {
            hasTrickster= true;
        }
        else
        {
            hasTrickster = false;
        }
    }
}
