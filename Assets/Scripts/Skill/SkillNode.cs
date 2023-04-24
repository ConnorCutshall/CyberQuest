using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillNode : MonoBehaviour
{
    public string skillName;
    public List<GameObject> nextSkills;
    //public List<GameObject> lines;
    public SkillNode prevSkill;

    public UpgradeData upgradeData;

    public bool canUnlock;
    public bool isUnlocked;
    public int nextLevelUnlockCost;

    public TMP_Text costText;
    public TMP_Text levelText;
    public TMP_Text moneyText;
    public NodeType nodeType;

    public int level;
    public Button button;

    //public Color unlockedColor;
    //public Color lockedColor;

    public enum NodeType {VPN, FireWall }

    public void Start()
    {
        //setup button
        button = GetComponent<Button>();
        button.onClick.AddListener(buttonPush);
        //update level string text
        switch (nodeType)
        {
            case NodeType.VPN:
                level = upgradeData.VPNLevel;
                break;
            case NodeType.FireWall:
                level = upgradeData.FireWallLevel;
                break;
        }

        //push Update
        pushUpdate();
    }
    public void Update()
    {
        //button setup was here
    }
    void pushUpdate() 
    {
        //update level text
        levelText.text = level.ToString();
        moneyText.text = "$" + upgradeData.playerMoney.ToString();
        if (level == 10)
        {
            costText.gameObject.SetActive(false);
        }
        else 
        {
            costText.text = "$" + nextLevelUnlockCost;
        }

        if (level == 0) 
        {
            levelText.gameObject.SetActive(false);
        }

        if (level == 1) 
        {
            levelText.gameObject.SetActive(true);
        }

        // updates color of node and corresponding lines
        //if (this.isUnlocked)
        //{
        //    this.GetComponent<Image>().color = unlockedColor;
        //    foreach (GameObject line in lines) 
        //    {
        //        line.GetComponent<Image>().color = unlockedColor;
        //    }
        //}
        //else 
        //{
        //    this.GetComponent<Image>().color = lockedColor;
        //    foreach (GameObject line in lines)
        //    {
        //        line.GetComponent<Image>().color = lockedColor;
        //    }
        //}

        //updates inormation in sriptable object
        switch (nodeType)
        {
            case NodeType.VPN:
                upgradeData.VPNLevel = level;
                break;
            case NodeType.FireWall:
                upgradeData.FireWallLevel = level;
                break;
        }

    }
    void buttonPush() 
    {
        //test to see if the node can be unlocked
        if (!isUnlocked && canUnlock) 
        {
            isUnlocked = true;
            foreach (GameObject skill in nextSkills) 
            {
                skill.GetComponent<SkillNode>().canUnlock = true;
            }
        }

        if (upgradeData.playerMoney >= nextLevelUnlockCost
            && level < 10) 
        {
            level++;
            upgradeData.playerMoney -= nextLevelUnlockCost;
            nextLevelUnlockCost += 50;
        }
        pushUpdate();
    }
}
