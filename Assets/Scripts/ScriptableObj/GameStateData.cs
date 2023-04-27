using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GameStateData Object", menuName = "Data/GameStateData")]
public class GameStateData : ScriptableObject
{
    public int roundNum;
    public int castleData = 2000;
}
