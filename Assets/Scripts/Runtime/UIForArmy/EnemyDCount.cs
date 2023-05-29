using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyDCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI eCounterDisplay;
    [SerializeField] private GameObject ECountTot;
    [SerializeField] private HoldArmyObject ETotFind;
void Awake()
    {
        ETotFind = GameObject.Find("GameplayManager").GetComponent<HoldArmyObject>();
    }
void Update()
    {
        ECountTot = ETotFind.enemyArmyClicked;

        if(ECountTot != null)
        eCounterDisplay.text = "" + ECountTot.GetComponent<EnemyLifeAndAttack>().enemyDefenderC();
    }
}
