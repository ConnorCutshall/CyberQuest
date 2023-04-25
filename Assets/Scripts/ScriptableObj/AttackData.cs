using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AttackData Object", menuName = "Data/AttackData")]
public class AttackData : ScriptableObject
{
    public int PeasantLevel;
    public int TheifLevel;
    public int TricksterLevel;
    public int ImposterLevel;

}
