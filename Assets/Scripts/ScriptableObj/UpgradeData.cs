using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UpgradeData Object", menuName = "Data/UpgradeData")]
public class UpgradeData : ScriptableObject
{
    public int playerMoney = 100;

    //tier 1
    public int EncryptionLevel = -1;
    public int FireWallLevel = -1;
    public int SegmentationLevel = -1;

    //tier 2
    public int VPNLevel = -1;
    public int TwoFactorLevel = -1;
    public int BackupLevel = -1;

    //tier 3
    public int EducationLevel = -1;

    public int[] upgrades = {-1, -1, -1, -1, -1, -1, -1};

    //public void Awake()
    //{
    //    //tier 1
    //    EncrytpionLevel = -1;
    //    FireWallLevel = -1;
    //    SegmentationLevel = -1;

    //    //tier 2
    //    VPNLevel = -2;
    //    TwoFactorLevel = -2;
    //    BackupLevel = -2;

    //    //tier 3
    //    EducationLevel = -2;
    //    PlayerAttackLevel = -2;
    //    PlayerSpeedLevel = -2;
    //}
}
