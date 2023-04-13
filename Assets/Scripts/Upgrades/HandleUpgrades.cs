using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUpgrades : MonoBehaviour
{
    public bool hasFireWall = true;
    public bool hasVPN = true;
    public bool hasEncryption = true;

    public GameObject FireWall;
    public GameObject VPN;
    public GameObject Encryption;

    public void Update()
    {
        HandleFireWall();
        HandleVPN();
        HandleEncyption();

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
    public void HandleEncyption() 
    {
        if (hasEncryption)
        {
            Encryption.SetActive(true);
        }
        else
        {
            Encryption.SetActive(false);
        }
    }
}
