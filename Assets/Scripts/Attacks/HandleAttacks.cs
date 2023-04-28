using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static Unity.Collections.Unicode;

public class HandleAttacks : MonoBehaviour
{
    public bool hasPeasant = true;
    public bool hasThief = true;
    public bool hasTrickster = true;
    public bool hasImposter = true;

    public GameObject peasantHandler;
    public GameObject thiefHandler;
    public GameObject tricksterHandler;
    public GameObject imposterHandler;

    public GameStateData gamestate;
    public AttackData wideAttackData;

    //public AttackData attackData;
    public void Start()
    {
        Attacks(gamestate.roundNum);
    }

    public void Attacks(int round)
    {
        int tier = Mathf.Min(((round + 2) / 3), 3); // The tier increases every 3 levels, to a max of 3
        int attacks = Mathf.Min(((round + 1) / 2), 5); // The number of attacks increases every other level, to a max of 6

        int[] attackData = {0, 0, 0, 0, 0}; // Stores the values for the attacks. 0 unpicked, 1 picked

        // Determines attacks
        for (int i = 0; i < attacks; i++)
        {
            int attack = Mathf.Min((Random.Range(0, tier * 2)), 4);
            if (attackData[attack] == 0)
            {
                attackData[attack] = 1;
                wideAttackData.pastAttacks[attack] = true;
            }
            else
            {
                i--;
            }
        }
        // Triggers events
        if (attackData[0] == 1)
        {
            // MitM
            thiefHandler.GetComponent<HandleThief>().HandleThieves();
        }
        if (attackData[1] == 1)
        {
            // DoS
            peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
        }
        if (attackData[2] == 1)
        {
            // DNS Spoofing
            tricksterHandler.GetComponent<HandleTrickster>().HandleTricksters();
        }
        if (attackData[3] == 1)
        {
            // Phishing
        }
        if (attackData[4] == 1)
        {
            // Password Attack
            imposterHandler.GetComponent<HandleImposter>().HandleImposters();
        }
    }
}



