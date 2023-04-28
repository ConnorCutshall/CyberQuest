using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GameStateData Object", menuName = "Data/GameStateData")]
public class GameStateData : ScriptableObject
{
    public int roundNum = 1;
    public int castleData = 2000;
}
