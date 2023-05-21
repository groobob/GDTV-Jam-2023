using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITransition : MonoBehaviour
{
    
    private TMP_Text text;
    public void fadeInText(GameObject textObject, float duration)
    {
        text = textObject.GetComponent<TMP_Text>();
        Debug.Log(text);
        var color = text.color;
        var fadeoutcolor = color;
        fadeoutcolor.a = 0;
        LeanTween.value(gameObject, updateValueExampleCallback, fadeoutcolor, color, duration);
    }
    public void fadeOutText(GameObject textObject, float duration)
    {
        text = textObject.GetComponent<TMP_Text>();
        Debug.Log(text);
        var color = text.color;
        var fadeoutcolor = color;
        fadeoutcolor.a = 0;
        LeanTween.value(gameObject, updateValueExampleCallback, color, fadeoutcolor, duration);
    }
    void updateValueExampleCallback(Color val)
    {
        text.color = val;
    }
}
