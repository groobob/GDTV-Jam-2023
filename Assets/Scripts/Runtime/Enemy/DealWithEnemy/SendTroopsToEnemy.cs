using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SendTroopsToEnemy : MonoBehaviour
{
    public TMP_InputField warriorField;
    public TMP_InputField bowField;
    public TMP_InputField defenderField;

    [SerializeField] private int amountWarrior = 0;
    [SerializeField] private int amountRanger = 0;
    [SerializeField] private int amountDefender = 0;

    [SerializeField] private GameObject submitbutton;
    [SerializeField] private GameObject ObjectGetter;

    public void OntroopAmount()
    {
        int maxTroops = (int) GameObject.Find("InitManager").GetComponent<ResourceManager>().GetPopulation();
            int.TryParse(warriorField.text, out amountWarrior);
            int.TryParse(bowField.text, out amountRanger);
            int.TryParse(defenderField.text, out amountDefender);

        if(amountDefender + amountRanger + amountWarrior > 0 && amountDefender + amountRanger + amountWarrior < maxTroops)
            submitbutton.GetComponent<Button>().interactable = true;
        else submitbutton.GetComponent<Button>().interactable = false;
    }

    public void submitTroops()
    {
        ObjectGetter = GameObject.Find("GameplayManager").GetComponent<HoldArmyObject>().enemyArmyClicked;
        ObjectGetter.GetComponent<EnemyLifeAndAttack>().startBattle(amountWarrior, amountRanger, amountDefender);
        FindObjectOfType<ViewManager>().GetComponent<ViewManager>().UnloadScene(GameScenes.ArmyUIScene1);
    }
}
