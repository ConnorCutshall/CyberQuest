using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateData : MonoBehaviour
{
    public TMP_Text dataText;
    public GameStateData gamestate;
    public void Update()
    {
        dataText.text = "Data: " + gamestate.castleData.ToString();
    }
}
