using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyBuildingScript : MonoBehaviour
{
    private float WarriorBuff = 1;
    private float BowBuff = 1;
    private float DefenderBuff = 1;

    public void OnWarriorPurchase()
    {
        WarriorBuff += 0.05f;
    }
    public void OnBowPurchase()
    {
        BowBuff += 0.05f;
    }
    public void OnDefenderPurchase()
    {
        DefenderBuff += 0.05f;
    }

    public float GetWarriorBuff()
    {
        return WarriorBuff;
    }
    public float GetBowBuff()
    {
        return BowBuff;
    }
    public float GetDefenderBuff()
    {
        return DefenderBuff;
    }
    public void SetWarriorBuff(float BuffAmount)
    {
        WarriorBuff = BuffAmount;
    }
    public void SetBowBuff(float BuffAmount)
    {
        BowBuff = BuffAmount;
    }
    public void SetDefenderBuff(float BuffAmount)
    {
        DefenderBuff = BuffAmount;
    }
}
