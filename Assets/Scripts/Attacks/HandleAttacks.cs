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

}
