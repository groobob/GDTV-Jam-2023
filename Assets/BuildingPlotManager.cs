using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingPlotManager : MonoBehaviour
{
    public static event Action OnFarmEffect;
    public static event Action OnHouseEffect;
    public static event Action OnSwordEffect;
    public static event Action OnBowEffect;
    public static event Action OnShieldEffect;

    [SerializeField] private Sprite plotSprite;
    [SerializeField] private BuildingType buildingType;

    [SerializeField] private Image plotImage;
    private bool hasEffect = false;

    [Header("Timer System")]
    public float timer;
    public float timerLength;

    private void OnEnable()
    {
        CityMapClickEvents.OnPlotChange += CityMapClickEvents_OnPlotChange;
    }

    private void CityMapClickEvents_OnPlotChange(Sprite plot, BuildingType type)
    {
        if (plotImage.transform.parent.gameObject != FindObjectOfType<CityMapClickEvents>().GetComponent<CityMapClickEvents>().CurrentPlot) return;
        plotSprite = plot;
        buildingType = type;

        plotImage.sprite = plotSprite;
        hasEffect = true;

        GameObject.Find("CanvasActivator1").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("CanvasActivator2").transform.GetChild(0).gameObject.SetActive(true);
    }


    void Update()
    {
        if (hasEffect == false) return;


        if(timer <= 0f)
        {
            switch (buildingType)
            {
                case BuildingType.house:
                    InvokeHouseEffect();
                    break;
                case BuildingType.farm:
                    InvokeFarmEffect();
                    break;
                case BuildingType.sword:
                    InvokeSwordEffect();
                    break;
                case BuildingType.bow:
                    InvokeShieldEffect();
                    break;
                case BuildingType.shield:
                    InvokeShieldEffect();
                    break;
            }

            timer = timerLength;
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }

    public void InvokeFarmEffect() => OnFarmEffect?.Invoke();
    public void InvokeHouseEffect() => OnHouseEffect?.Invoke();
    public void InvokeSwordEffect() => OnSwordEffect?.Invoke();
    public void InvokeBowEffect() => OnBowEffect?.Invoke();
    public void InvokeShieldEffect() => OnShieldEffect?.Invoke();
}
