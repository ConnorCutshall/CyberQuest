using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PastAttackDisplayer : MonoBehaviour
{
    public AttackData wideAttackData;

    public GameObject mitmPast;
    public GameObject dosPast;
    public GameObject dnsPast;
    public GameObject phishingPast;
    public GameObject passwordPast;

    // Update is called once per frame
    void Update()
    {
        mitmPast.SetActive(wideAttackData.pastAttacks[0]);
        dosPast.SetActive(wideAttackData.pastAttacks[1]);
        dnsPast.SetActive(wideAttackData.pastAttacks[2]);
        phishingPast.SetActive(wideAttackData.pastAttacks[3]);
        passwordPast.SetActive(wideAttackData.pastAttacks[4]);
    }

}
