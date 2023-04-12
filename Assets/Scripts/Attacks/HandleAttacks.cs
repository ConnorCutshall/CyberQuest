using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class HandleAttacks : MonoBehaviour
{
    public bool hasPeasant = true;
    public bool hasThief = true;

    public GameObject peasantHandler;
    public GameObject thiefHandler;
    public void Start()
    {
        if (hasPeasant) 
        {
            peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
        }        
        if (hasThief) 
        {
            thiefHandler.GetComponent<HandleThief>().HandleThiefs();
        }
        
    }

}
