using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleController : MonoBehaviour
{
    public GameStateData gameStateData;
    public UpgradeData upgradeData;
    void Start()
    {
        getUnlock(upgradeData.upgrades, gameStateData.roundNum);
    }
    //here starts the unlocking logic
    public static void getUnlock(int[] upgrades, int round)
    {
        int[] options = new int[upgrades.Length];
        for (int i = 0; i < options.Length; i++)
        {
            options[i] = upgrades[i];
        }
        int tier = Mathf.Min(((round + 2) / 3), 3); // The tier increases every 3 levels, to a max of 3
        int choiceOne = -1, choiceTwo = -1; // Determines which two upgrades will be show
        int index;

        while (choiceOne == -1 || choiceTwo == -1)
        {
            index = Random.Range(0, tier * 3); // Rolls upgrade option
            if ((index + 1) % 3 == 0)
            {
                index = Random.Range(0, tier * 3); // Re-rolls on rare upgrades
            }

            if (options[index] == 0 && choiceOne == -1)
            {
                options[index] = 1;
                choiceOne = index;
            }
            else if (options[index] == 0)
            {
                options[index] = 1;
                choiceTwo = index;
            }

            if ((round) % 3 == 0)
            {
                choiceTwo = choiceOne;
            }
        }

        revealer(choiceOne);
        revealer(choiceTwo);
    }

    public static void revealer(int option)
    {
        // Shows the two upgrade options
        switch (option)
        {
            case 0:
                // Show option to get Encryption
                break;
            case 1:
                // Show option to get Firewalls
                break;
            case 2:
                // Show option to get Segmentation
                break;
            case 3:
                // Show option to get VPN
                break;
            case 4:
                // Show option to get Auth
                break;
            case 5:
                // Show option to get Backups
                break;
            case 6:
                // Show option to get Education
                break;
            case 7:
                // Show option to get Attack Speed
                break;
            case 8:
                // Show option to get Movement Speed
                break;
            default:
                // Handles exceptions. Just leave blank
                break;
        }
    }
    //here ends the unlocking logic
}
