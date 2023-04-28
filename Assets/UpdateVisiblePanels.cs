using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVisiblePanels : MonoBehaviour
{
    public GameObject EncryptionPast;
    public GameObject FireWallPast;
    public GameObject SegmentationPast;

    public GameObject VPNPast;
    public GameObject TwoFactorPast;
    public GameObject BackupsPast;

    public GameObject EducationPast;


    public UpgradeData upgradeData;

    // Update is called once per frame
    void Update()
    {
        if (upgradeData.EncryptionLevel > 0) {
            EncryptionPast.SetActive(true);
            //Encryption.GetComponent<SkillNode>().UpdateLevel();
        }else {
            EncryptionPast.SetActive(false);
        }


        if (upgradeData.FireWallLevel > 0){
            FireWallPast.SetActive(true);
            //FireWall.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            FireWallPast.SetActive(false);
        }


        if (upgradeData.SegmentationLevel > 0){
            SegmentationPast.SetActive(true);
            //Segmentation.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            SegmentationPast.SetActive(false);
        }


        if (upgradeData.VPNLevel > 0){
            VPNPast.SetActive(true);
            //VPN.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            VPNPast.SetActive(false);
        }


        if (upgradeData.TwoFactorLevel > 0){
            TwoFactorPast.SetActive(true);
            //TwoFactor.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            TwoFactorPast.SetActive(false);
        }

        if (upgradeData.BackupLevel > 0)
        {
            BackupsPast.SetActive(true);
            //Backups.GetComponent<SkillNode>().UpdateLevel();
        }else{
            BackupsPast.SetActive(false);
        }

        if (upgradeData.EducationLevel > 0){
            EducationPast.SetActive(true);
            //Education.GetComponent<SkillNode>().UpdateLevel();
        }
        else{
            EducationPast.SetActive(false);
        }





    }
}
