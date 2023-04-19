using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBar : MonoBehaviour
{
    public GameObject CurrPage;

    public GameObject SkillTree;
    public GameObject Stats;
    public void LoadSkillTree() 
    {
        if (CurrPage != null)
        {
            CurrPage.SetActive(false);
        }
        SkillTree.SetActive(true);
        CurrPage = SkillTree;
    }
    public void LoadStats()
    {
        if (CurrPage != null)
        {
            CurrPage.SetActive(false);
        }
        Stats.SetActive(true);
        CurrPage = Stats;
    }
}
