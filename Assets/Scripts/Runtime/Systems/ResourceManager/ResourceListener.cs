using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceListener : MonoBehaviour
{
    [SerializeField] private TMP_Text goldText;
    [SerializeField] private TMP_Text populationText;
    [SerializeField] private TMP_Text healthText;

    private void Awake()
    {
        goldText.text = $"Gold: {ResourceManager.Resources.gold}";
        populationText.text = $"Population: {ResourceManager.Resources.population}";
        healthText.text = $"Health: {ResourceManager.Resources.health}";
    }

    private void OnEnable()
    {
        ResourceManager.OnGoldChange += ResourceManager_OnGoldChange;
        ResourceManager.OnPopulationChange += ResourceManager_OnPopulationChange;
        ResourceManager.OnHealthChange += ResourceManager_OnHealthChange;
    }

    private void OnDisable()
    {
        ResourceManager.OnGoldChange -= ResourceManager_OnGoldChange;
        ResourceManager.OnPopulationChange -= ResourceManager_OnPopulationChange;
        ResourceManager.OnHealthChange -= ResourceManager_OnHealthChange;
    }

    private void ResourceManager_OnHealthChange()
    {
        healthText.text = $"Health: {ResourceManager.Resources.health}";
    }

    private void ResourceManager_OnPopulationChange()
    {
        populationText.text = $"Population: {ResourceManager.Resources.population}";
    }

    private void ResourceManager_OnGoldChange()
    {
        goldText.text = $"Gold: {ResourceManager.Resources.gold}";
    }
}
