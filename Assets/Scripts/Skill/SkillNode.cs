using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillNode : MonoBehaviour
{
    public string skillName;
    public List<GameObject> nextSkills;
    public List<GameObject> lines;
    public SkillNode prevSkill;

    public UpgradeData upgradeData;

    public bool canUnlock;
    public bool isUnlocked;

    public TMP_Text level;
    public NodeType nodeType;

    public Button button;
    public Color unlockedColor;
    public Color lockedColor;

    public enum NodeType {VPN, FireWall }

    public void Start()
    {
        button = GetComponent<Button>();
        switch (nodeType)
        {
            case NodeType.VPN:
                level.text = upgradeData.VPNLevel.ToString();
                break;
            case NodeType.FireWall:
                level.text = upgradeData.FireWallLevel.ToString();
                break;
        }

        pushUpdate();
    }
    public void Update()
    {
        button.onClick.AddListener(buttonPush);
    }
    void pushUpdate() 
    {
        if (this.isUnlocked)
        {
            this.GetComponent<Image>().color = unlockedColor;
            foreach (GameObject line in lines) 
            {
                line.GetComponent<Image>().color = unlockedColor;
            }
        }
        else 
        {
            this.GetComponent<Image>().color = lockedColor;
            foreach (GameObject line in lines)
            {
                line.GetComponent<Image>().color = lockedColor;
            }
        }
    }
    void buttonPush() 
    {
        if (!isUnlocked && canUnlock) 
        {
            isUnlocked = true;
            foreach (GameObject skill in nextSkills) 
            {
                skill.GetComponent<SkillNode>().canUnlock = true;
            }
            pushUpdate();
        }
    }

}
