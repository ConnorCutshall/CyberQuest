using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawBridge : MonoBehaviour
{
    public GameObject Up;
    public GameObject Down;

    public void SetDrawBridge(bool isDown) 
    {
        if (isDown)
        {
            Up.SetActive(false);
            Down.SetActive(true);
        }
        else
        {
            Up.SetActive(true);
            Down.SetActive(false);
        }
    }
}
