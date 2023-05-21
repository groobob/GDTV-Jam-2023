using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITransition : MonoBehaviour
{
    
    private TMP_Text text;
    public void fadeInText()
    {
        text = GetComponent<TMP_Text>();
        var color = text.color;
        var fadeoutcolor = color;
        fadeoutcolor.a = 0;
        LeanTween.value(gameObject, updateValueExampleCallback, fadeoutcolor, color, 1f);
    }
    public void fadeOutText()
    {
        text = GetComponent<TMP_Text>();
        var color = text.color;
        var fadeoutcolor = color;
        fadeoutcolor.a = 0;
        LeanTween.value(gameObject, updateValueExampleCallback, color, fadeoutcolor, 1f);
    }
    void updateValueExampleCallback(Color val)
    {
        text.color = val;
    }
}
