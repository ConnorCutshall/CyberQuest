using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New UpgradeData Object", menuName = "Data/UpgradeData")]
public class UpgradeData : ScriptableObject
{
    public int playerMoney;

    public int FireWallLevel;
    public int VPNLevel;
}
