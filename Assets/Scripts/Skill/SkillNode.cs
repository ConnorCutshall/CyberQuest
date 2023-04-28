using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillNode : MonoBehaviour
{
    public string skillName;
    //public List<GameObject> lines;

    public UpgradeData upgradeData;

    public bool canUnlock;
    public bool isUnlocked;
    public int nextLevelUnlockCost;

    public TMP_Text costText;
    public TMP_Text levelText;
    public TMP_Text moneyText;
    public NodeType nodeType;

    public int level;
    public Button button;

    //public Color unlockedColor;
    //public Color lockedColor;

    public enum NodeType {VPN, FireWall, Encryption, Education, TwoFactor, Segmentation, Backups,}

    public void Start()
    {
        //UpdateLevel();

        //setup button
        button = GetComponent<Button>();
        button.onClick.AddListener(buttonPush);
        //update level string text
    }

    public void UpdateLevel() 
    {
        switch (nodeType)
        {
            case NodeType.VPN:
                level = upgradeData.VPNLevel;
                break;
            case NodeType.FireWall:
                level = upgradeData.FireWallLevel;
                break;
            case NodeType.Encryption:
                level = upgradeData.EncryptionLevel;
                break;
            case NodeType.TwoFactor:
                level = upgradeData.TwoFactorLevel;
                break;
            case NodeType.Education:
                level = upgradeData.EducationLevel;
                break;
            case NodeType.Segmentation:
                level = upgradeData.SegmentationLevel;
                break;
            case NodeType.Backups:
                level = upgradeData.BackupLevel;
                break;
        }
    }
    public void pushUpdate() 
    {
        GameObject obj=  this.gameObject.transform.parent.gameObject;

        for (int i = 0; i < obj.transform.childCount; i++) 
        {
            obj.transform.GetChild(i).gameObject.SetActive(false);
        }

        switch (nodeType)
        {
            case NodeType.VPN:
                upgradeData.VPNLevel = 1;
                upgradeData.upgrades[3] = 1;
                break;
            case NodeType.FireWall:
                upgradeData.FireWallLevel = 1;
                upgradeData.upgrades[1] = 1;
                break;
            case NodeType.Encryption:
                upgradeData.EncryptionLevel = 1;
                upgradeData.upgrades[0] = 1;
                break;
            case NodeType.TwoFactor:
                upgradeData.TwoFactorLevel = 1;
                upgradeData.upgrades[4] = 1;
                break;
            case NodeType.Education:
                upgradeData.EducationLevel = 1;
                upgradeData.upgrades[6] = 1;
                break;
            case NodeType.Segmentation:
                upgradeData.SegmentationLevel = 1;
                upgradeData.upgrades[2] = 1;
                break;
            case NodeType.Backups:
                upgradeData.BackupLevel = 1;
                upgradeData.upgrades[5] = 1;
                break;

        }


    }
    void buttonPush() 
    {
        pushUpdate();
    }
}
