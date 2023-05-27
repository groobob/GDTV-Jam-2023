using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static event Action OnEmptyHealth;
    public static event Action OnGoldChange;
    public static event Action OnPopulationChange;
    public static event Action OnHealthChange;

    [SerializeField] private static GameResources resources;
    [SerializeField] private int startingGold;
    [SerializeField] private int startingHealth;
    [SerializeField] private int startingPopulation;

    public static GameResources Resources { get => resources; set => resources = value; }

    private void Awake()
    {
        resources.gold = startingGold;
        resources.population = startingPopulation;
        resources.health = startingHealth;
    }

    private void OnEnable()
    {
        CityMapClickEvents.OnBuildingBought += CityMapClickEvents_OnBuildingBought;
        BuildingPlotManager.OnHouseEffect += BuildingPlotManager_OnHouseEffect;
        BuildingPlotManager.OnFarmEffect += BuildingPlotManager_OnFarmEffect;
        MoveToCastle.OnCastleReached += MoveToCastle_OnCastleReached;
    }

    private void MoveToCastle_OnCastleReached(int damage)
    {
        AdjustHealth(-damage);
    }

    private void BuildingPlotManager_OnFarmEffect()
    {
        AdjustGold(2);
    }

    private void BuildingPlotManager_OnHouseEffect()
    {
        AdjustPopulation(10);
    }

    private void OnDisable()
    {
        CityMapClickEvents.OnBuildingBought -= CityMapClickEvents_OnBuildingBought;
    }

    private void CityMapClickEvents_OnBuildingBought(int gold)
    {
        AdjustGold(-gold);
    }

    public void AdjustGold(int gold)
    {
        resources.gold += gold;
        OnGoldChange?.Invoke();
    }

    public void AdjustPopulation(int population)
    {
        resources.population += population;
        OnPopulationChange?.Invoke();
    }

    public void AdjustHealth(int health)
    {
        resources.health += health;
        OnHealthChange.Invoke();

        if (resources.health <= 0)
        {
            OnEmptyHealth?.Invoke();
        }
    }
}

public struct GameResources
{
    public int gold;
    public int health;
    public int population;
}
