using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateData : MonoBehaviour
{
    public TMP_Text dataText;
    public TMP_Text moneyText;

    public GameStateData gamestate;
    public UpgradeData upgradeData;
    public void Update()
    {
        dataText.text = "Data: " + gamestate.castleData.ToString() + " bytes";
        moneyText.text = "Money: $" + upgradeData.playerMoney.ToString();
    }
}
