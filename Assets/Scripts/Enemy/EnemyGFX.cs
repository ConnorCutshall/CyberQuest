using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aipath;

    void Update()
    {
        if (aipath.desiredVelocity.x >= 0.01f) 
        {

        }
    }
}
