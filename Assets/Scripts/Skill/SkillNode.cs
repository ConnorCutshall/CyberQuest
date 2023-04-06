using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillNode : MonoBehaviour
{
    public string skillName;
    public List<GameObject> nextSkills;
    public List<GameObject> lines;
    public SkillNode prevSkill;

    public bool canUnlock;
    public bool isUnlocked;

    public Button button;
    public Color unlockedColor;
    public Color lockedColor;

    public void Start()
    {
        button = GetComponent<Button>();
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
