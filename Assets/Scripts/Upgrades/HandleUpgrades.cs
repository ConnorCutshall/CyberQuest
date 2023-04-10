using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUpgrades : MonoBehaviour
{
    public bool hasFireWall = true;
    public bool hasVPN = true;

    public GameObject FireWall;
    public GameObject VPN;

    public void Update()
    {
        HandleFireWall();
        HandleVPN();

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
    public void HandleVPN() 
    {
        if (hasVPN)
        {
            VPN.SetActive(true);
        }
        else
        {
            VPN.SetActive(false);
        }
    }
}
