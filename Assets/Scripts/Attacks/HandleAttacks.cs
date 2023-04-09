using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class HandleAttacks : MonoBehaviour
{
    public bool hasPeasant = true;
    public GameObject peasantHandler;

    public void Start()
    {
        if (hasPeasant) 
        {
            peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
        }
        
    }

}
