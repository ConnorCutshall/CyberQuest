using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AttackData Object", menuName = "Data/AttackData")]
public class AttackData : ScriptableObject
{
    public List<GameObject> EnemyList;
}
