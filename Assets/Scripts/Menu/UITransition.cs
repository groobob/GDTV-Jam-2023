using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITransition : MonoBehaviour
{
    
    TextMeshProUGUI text;
    public void fadeOutText()
    {
        LeanTween.alpha(gameObject, 0, 5f);
    }
    void Start()
    {
        Debug.Log(gameObject);
        //gameObject.GetComponent<TextMeshProUGUI>().alpha = 0.5f;
        //LeanTween.color(gameObject, new Color(1,1,1,0), 1);
        text = GetComponent<TextMeshProUGUI>();
        var color = text.color;
        var fadeoutcolor = color;
        fadeoutcolor.a = 0;
        LeanTween.value(gameObject, updateValueExampleCallback, fadeoutcolor, color, 1f).setEase(LeanTweenType.easeOutElastic).setDelay(2f);
    }
    void updateValueExampleCallback(Color val)
    {
        text.color = val;
    }
}
