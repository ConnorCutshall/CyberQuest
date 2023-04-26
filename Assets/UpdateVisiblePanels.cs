using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVisiblePanels : MonoBehaviour
{
    public GameObject Encryption;
    public GameObject FireWall;
    public GameObject Segmentation;

    public GameObject VPN;
    public GameObject TwoFactor;
    public GameObject Backups;

    public GameObject Education;
    public GameObject Attack;
    public GameObject Speed;

    public UpgradeData upgradeData;

    // Update is called once per frame
    void Update()
    {
        if (upgradeData.EncrytpionLevel > -1) {
            Encryption.SetActive(true);
            Encryption.GetComponent<SkillNode>().UpdateLevel();
        }else { 
            Encryption.SetActive(false);
        }


        if (upgradeData.FireWallLevel > -1){
            FireWall.SetActive(true);
            FireWall.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            FireWall.SetActive(false);
        }


        if (upgradeData.SegmentationLevel > -1){
            Segmentation.SetActive(true);
            Segmentation.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            Segmentation.SetActive(false);
        }


        if (upgradeData.VPNLevel > -1){
            VPN.SetActive(true);
            VPN.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            VPN.SetActive(false);
        }


        if (upgradeData.TwoFactorLevel > -1){
            TwoFactor.SetActive(true);
            TwoFactor.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            TwoFactor.SetActive(false);
        }

        if (upgradeData.BackupLevel > -1)
        {
            Backups.SetActive(true);
            Backups.GetComponent<SkillNode>().UpdateLevel();
        }else{
            Backups.SetActive(false);
        }

        if (upgradeData.EducationLevel > -1){
            Education.SetActive(true);
            Education.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            Education.SetActive(false);
        }


        if (upgradeData.PlayerAttackLevel > -1){
            Attack.SetActive(true);
            Attack.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            Attack.SetActive(false);
        }


        if (upgradeData.PlayerSpeedLevel > -1)
        {
            Speed.SetActive(true);
            Speed.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            Speed.SetActive(false);
        }
    }
}
