using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLifeAndAttack : MonoBehaviour
{
    [SerializeField] private int warriorAmount;
    [SerializeField] private int rangerAmount;
    [SerializeField] private int defenderAmount;

    [SerializeField] float timer1;
    [SerializeField] float timer2;
    [SerializeField] float timer3;

    [SerializeField] double timerWarriorDeath = 1;
    [SerializeField] double timer2RangerDeath = 1;
    [SerializeField] double timer3DefenderDeath = 1;


    private int warriorAmountAlly;
    private int rangerAmountAlly;
    private int defenderAmountAlly;

    float timer1Ally;
    float timer2Ally;
    float timer3Ally;

    [SerializeField] double timerWarriorDeathAlly = 1;
    [SerializeField] double timer2RangerDeathAlly = 1;
    [SerializeField] double timer3DefenderDeathAlly = 1;

    private float WarriorBuff = 1;
    private float BowBuff = 1;
    private float DefenderBuff = 1;

    public bool isfighting = false;
    
    void Awake()
    {   
        float enemyspawnbasetime = this.gameObject.transform.parent.gameObject.transform.parent.gameObject.GetComponent<EnemySpawner>().timeSinceEnabled;
        warriorAmount = (int) Random.Range(1+(enemyspawnbasetime/60), 10+(enemyspawnbasetime/10));
        rangerAmount = (int) Random.Range(1+(enemyspawnbasetime/60), 10+(enemyspawnbasetime/10));
        defenderAmount = (int) Random.Range(1+(enemyspawnbasetime/60), 10+(enemyspawnbasetime/10));

        WarriorBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetWarriorBuff();
        BowBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetBowBuff();
        DefenderBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetDefenderBuff();
    }

    void Update()
    {
        if(isfighting == true)
        {
            if(timer1 >= timerWarriorDeath && warriorAmount > 0)
            {
                warriorAmount--;
                timer1 = 0;
                timerWarriorDeath = 2*((warriorAmount/10)/((warriorAmountAlly * WarriorBuff) + (rangerAmountAlly * BowBuff) + (defenderAmountAlly*DefenderBuff) + (.1 * rangerAmountAlly*BowBuff)));
            }

            if(timer2 >= timer2RangerDeath && rangerAmount > 0)
            {
                rangerAmount--;
                timer2 = 0;
                timer2RangerDeath = 2*((warriorAmount/10)/((warriorAmountAlly*WarriorBuff) + (rangerAmountAlly*BowBuff) + (defenderAmountAlly*DefenderBuff) + (.1 * defenderAmountAlly*DefenderBuff)));
            }

            if(timer3 >= timer3DefenderDeath && defenderAmount > 0)
            {
                defenderAmount--;
                timer3 = 0;
                timer3DefenderDeath = 2*((warriorAmount/10)/((warriorAmountAlly*WarriorBuff) + (rangerAmountAlly*BowBuff) + (defenderAmountAlly*DefenderBuff) + (.1 * WarriorBuff*warriorAmountAlly)));
            }

            if(timer1Ally >= timerWarriorDeathAlly && warriorAmountAlly > 0)
            {
                warriorAmountAlly--;
                timer1Ally = 0;
                timerWarriorDeathAlly = 2*(((warriorAmountAlly*WarriorBuff)/10)/((warriorAmount) + (rangerAmountAlly) + (defenderAmount) + (.1 * rangerAmount)));
            }

            if(timer2Ally >= timer2RangerDeathAlly && rangerAmountAlly > 0)
            {
                rangerAmountAlly--;
                timer2Ally = 0;
                timer2RangerDeathAlly = 2*(((rangerAmountAlly*BowBuff)/10)/((warriorAmount) + (rangerAmountAlly) + (defenderAmount) + (.1 * defenderAmount)));
            }

            if(timer3Ally >= timer3DefenderDeathAlly && defenderAmountAlly > 0)
            {
                defenderAmountAlly--;
                timer3Ally = 0;
                timerWarriorDeathAlly = 2*(((defenderAmount*DefenderBuff)/10)/((warriorAmount) + (rangerAmountAlly) + (defenderAmount) + (.1 * warriorAmount)));
            }

            timer1 += Time.deltaTime;
            timer2 += Time.deltaTime;
            timer3 += Time.deltaTime;
            timer1Ally += Time.deltaTime;
            timer2Ally += Time.deltaTime;
            timer3Ally += Time.deltaTime;

            if(timerWarriorDeath > 1000000)
                timerWarriorDeath = 1;
            if(timer2RangerDeath > 1000000)
                timer2RangerDeath = 1;
            if(timer3DefenderDeath > 1000000)
                timer3DefenderDeath = 1;

            if(defenderAmount+rangerAmount+warriorAmount <= 0)
                Destroy(this.gameObject);
            if(defenderAmountAlly+rangerAmountAlly+warriorAmountAlly <= 0)
            {
                timerWarriorDeath = 1;
                timer2RangerDeath = 1;
                timer3DefenderDeath = 1;
                stopBattle();
            }
        }
    }


    public void startBattle(int warriors, int rangers, int defenders)
    {
        warriorAmountAlly = warriors;
        rangerAmountAlly = rangers;
        defenderAmountAlly = defenders;

        WarriorBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetWarriorBuff();
        BowBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetBowBuff();
        DefenderBuff = GameObject.Find("GameplayManager").GetComponent<ArmyBuildingScript>().GetDefenderBuff();
        isfighting = true;

        GameObject temp;
        temp = GameObject.Find("GameplayManager").GetComponent<HoldArmyObject>().enemyArmyClicked;
        temp.GetComponent<MoveToCastle>().enabled = false;
    }

    public void stopBattle()
    {
        GameObject temp;
        temp = GameObject.Find("GameplayManager").GetComponent<HoldArmyObject>().enemyArmyClicked;
        temp.GetComponent<MoveToCastle>().enabled = true;
        isfighting = false;
    }

    public int enemyWarriorC()
    {
        return warriorAmount;
    }
    public int enemyRangerC()
    {
        return rangerAmount;
    }
    public int enemyDefenderC()
    {
        return defenderAmount;
    }
}
