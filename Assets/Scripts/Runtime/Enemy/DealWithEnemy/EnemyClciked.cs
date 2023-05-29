using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClciked : MonoBehaviour
{

    // Update is called once per frame
    public void AttemptTargetEnemy(GameObject enemy)
    {
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().LoadScene(GameScenes.ArmyUIScene1);
        GameObject.Find("GameplayManager").GetComponent<HoldArmyObject>().enemyArmyClicked = enemy;
    }
}
