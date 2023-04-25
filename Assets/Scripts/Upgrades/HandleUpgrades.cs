using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleUpgrades : MonoBehaviour
{
    public bool hasFireWall = false;
    public bool hasVPN = false;
    public bool hasEncryption = false;
    public bool hasTwoFactor = false;
    public bool hasEducation = false;

    public GameObject FireWall;
    public GameObject VPN;
    public GameObject Encryption;
    public GameObject TwoFactor;
    public GameObject Education;

    public UpgradeData upgradeData;
    public void Start()
    {
        if (upgradeData.VPNLevel > 0) 
        {
            hasVPN = true;
        }
        if (upgradeData.EncrytpionLevel > 0)
        {
            hasEncryption= true;
        }
        if (upgradeData.EducationLevel > 0)
        {
            hasEducation= true;
        }
        if (upgradeData.FireWallLevel > 0)
        {
            hasFireWall= true;
        }
        if (upgradeData.TwoFactorLevel > 0)
        {
            hasTwoFactor = true;
        }
    }

    public void Update()
    {
        HandleFireWall();
        HandleVPN();
        HandleEncyption();
        HandleTwoFactor();
        HandleEducation();

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
    public void HandleTwoFactor() 
    {
        if (hasTwoFactor)
        {
            TwoFactor.SetActive(true);
        }
        else
        {
            TwoFactor.SetActive(false);
        }
    }
    public void HandleEducation()
    {
        if (hasEducation)
        {
            Education.SetActive(true);
        }
        else
        {
            Education.SetActive(false);
        }
    }
}
