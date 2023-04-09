using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUpgrades : MonoBehaviour
{
    public bool hasFireWall = true;

    public GameObject FireWall;

    public void Update()
    {
            HandleFireWall();

    }
    public void HandleFireWall() 
    {
        if (hasFireWall)
        {
            FireWall.SetActive(true);
        }
        else
        {
            FireWall.SetActive(false);
        }
    }
}
