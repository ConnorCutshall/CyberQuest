using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cam;

    public GameObject UI;
    public bool uiEnabled;
    void Start()
    {
        uiEnabled = false;
        UI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey("q"))
        {
            //cam.GetComponent<CinemachineVirtualCamera>();
        }
        else 
        { 

        }

        if (Input.GetKeyDown("e") && !uiEnabled)
        {
            uiEnabled = true;
            UI.SetActive(true);
        }
        else if (Input.GetKeyDown("e") && uiEnabled)
        {
            uiEnabled = false;
            UI.SetActive(false);
        }

    }
}
