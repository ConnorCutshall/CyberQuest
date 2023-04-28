using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleController : MonoBehaviour
{
    public GameStateData gameStateData;
    public UpgradeData upgradeData;

    public GameObject Encryption;
    public GameObject FireWall;
    public GameObject Segmentation;

    public GameObject VPN;
    public GameObject TwoFactor;
    public GameObject Backups;

    public GameObject Education;

    public GameObject text;
    public GameObject FullMessage;


    void Start()
    {
        Encryption.SetActive(false);
        FireWall.SetActive(false);
        Segmentation.SetActive(false);

        VPN.SetActive(false);
        TwoFactor.SetActive(false);
        Backups.SetActive(false);

        Education.SetActive(false);
        FullMessage.SetActive(false);


        getUnlock(upgradeData.upgrades, gameStateData.roundNum);
    }
    //here starts the unlocking logic
    public void getUnlock(int[] upgrades, int round)
    {
        if (round > 7)
        {
            revealer(66);
        }
        else
        {

            int[] options = new int[upgrades.Length];
            for (int i = 0; i < options.Length; i++)
            {
                options[i] = upgrades[i];
            }




            int tier = Mathf.Min(((round + 2) / 3), 3); // The tier increases every 3 levels, to a max of 3
            int choiceOne = -1, choiceTwo = -1; // Determines which two upgrades will be show
            int bound = tier * 3;
            if (bound >= 7)
            {
                bound = 7;
            }
            int index;

            while (choiceOne == -1)
            {
                index = Random.Range(0, bound);
                if ((index + 1) % 3 == 0)
                {
                    index = Random.Range(0, bound); // Re-rolls on rare upgrades
                }

                if (options[index] == -1)
                {
                    options[index] = 0;
                    choiceOne = index;
                }
            }

            if ((round) % 3 == 0 || round == 7)
            {
                choiceTwo = -999;
            }
            else
            {
                while (choiceTwo == -1)
                {
                    index = Random.Range(0, bound); // Rolls upgrade option
                    if ((index + 1) % 3 == 0)
                    {
                        index = Random.Range(0, bound); // Re-rolls on rare upgrades
                    }

                    if (options[index] == -1)
                    {
                        options[index] = 0;
                        choiceTwo = index;
                    }



                }
            }

            revealer(choiceOne);
            revealer(choiceTwo);
        }
    }



    public void revealer(int option)
    {
        // Shows the two upgrade options
        text.SetActive(true);
        switch (option)
        {
            case 0:
                // Show option to get Encryption
                Debug.Log("Encryption");
                Encryption.SetActive(true);
                break;
            case 1:
                // Show option to get Firewalls
                Debug.Log("Firewalls");
                FireWall.SetActive(true);
                break;
            case 2:
                // Show option to get Segmentation
                Segmentation.SetActive(true);
                break;
            case 3:
                // Show option to get VPN
                VPN.SetActive(true);
                break;
            case 4:
                // Show option to get Auth
                TwoFactor.SetActive(true);
                break;
            case 5:
                // Show option to get Backups
                Backups.SetActive(true);
                break;
            case 6:
                // Show option to get Education
                Education.SetActive(true);
                break;
            case 66:
                FullMessage.SetActive(true);
                text.SetActive(false);
                break;
            default:
                Debug.Log("Only one option");
                // Handles exceptions. Just leave blank
                break;
        }
    }
    //here ends the unlocking logic
}
