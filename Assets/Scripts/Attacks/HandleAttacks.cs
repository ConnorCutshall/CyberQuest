using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

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
    public void Start()
    {

        //if (hasPeasant) 
        //{
        //    peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
        //}        
        //if (hasThief) 
        //{
        //    thiefHandler.GetComponent<HandleThief>().HandleThieves();
        //}
        //if (hasTrickster) 
        //{
        //    tricksterHandler.GetComponent<HandleTrickster>().HandleTricksters();
        //}
        //if (hasImposter)
        //{
        //    imposterHandler.GetComponent<HandleImposter>().HandleImposters();  
        //}
        Attacks(0);
    }



    public void Attacks(int round)
    {
        if (round < 10)
        {
            int tier = (round + 2) / 3;

            int[] pastAttacks = { -1, -1, -1, -1, 3, 4};

            for (int i = 0; i < tier; i++)
            {
                int attack =Random.Range(0, tier * 2);
                while (contains(pastAttacks, attack))
                {
                    attack = Random.Range(0, tier * 2);
                }
                pastAttacks[i] = attack;
                switch (attack)
                {
                    case 0:
                        thiefHandler.GetComponent<HandleThief>().HandleThieves();
                        break;
                    case 1:
                        peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
                        break;
                    case 2:
                        tricksterHandler.GetComponent<HandleTrickster>().HandleTricksters();
                        break;
                    case 3:
                        // Call Phishing
                        break;
                    case 4:
                        // Call Password
                        break;
                    case 5:
                        imposterHandler.GetComponent<HandleImposter>().HandleImposters();
                        break;
                    default:
                        // Handle default case
                        break;
                }
            }
        }
        else
        {
            // Handles post game
            int tier = round - 6;
            if (tier > 4)
            {
                tier = 4;
            }
            int[] pastAttacks = { -1, -1, -1, -1, 3, 4};

            for (int i = 0; i < tier; i++)
            {
                int attack = Random.Range(0, 6);
                while (contains(pastAttacks, attack))
                {
                    attack = Random.Range(0, 6);
                }
                pastAttacks[i] = attack;
                switch (attack)
                {
                    case 0:
                        // Call MitM
                        thiefHandler.GetComponent<HandleThief>().HandleThieves();
                        break;
                    case 1:
                        // Call DoS
                        peasantHandler.GetComponent<HandlePeasant>().HandlePeasants();
                        break;
                    case 2:
                        // Call DNS
                        tricksterHandler.GetComponent<HandleTrickster>().HandleTricksters();
                        break;
                    case 3:
                        // Call Phishing
                        break;
                    case 4:
                        // Call Password
                        break;
                    case 5:
                        // Call Drive By
                        imposterHandler.GetComponent<HandleImposter>().HandleImposters();
                        break;
                    default:
                        // Handle default case
                        break;
                }
            }
        }
    }
    public static bool contains(int[] array, int target)
    {
        bool contains = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                contains = true;
            }
        }
        return contains;
    }
    
}
