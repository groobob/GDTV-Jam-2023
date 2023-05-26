using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject grapgicParent;

    private float distanceX = 0;
    private float distanceY = 0;
    private const float ADDRANGEX = 6.5f;
    private const float ADDRANGEY = 6.5f;

    public AnimationCurve timerByTime;
    public float timer;
    public float timerValue;
    public float timeSinceEnabled;

    private void Start()
    {
        timerValue = timerByTime.Evaluate(timeSinceEnabled);
        timer = timerByTime.Evaluate(timeSinceEnabled);
    }

    void Update()
    {
        timeSinceEnabled += Time.deltaTime;
        if(timer <= 0f)
        {
            float radians = Mathf.Deg2Rad * (int)Random.Range(1, 360); //get radians

            //x and y distance for circle using sin and cos to always be on radius 
            distanceX = ((float)((Random.Range(0, 1) * 2) + ADDRANGEX)) * Mathf.Cos(radians);

            distanceY = ((float)((Random.Range(0, 1) * 2) + ADDRANGEY)) * Mathf.Sin(radians);

            Instantiate(prefab, transform.position + new Vector3(distanceX, distanceY, transform.position.z), Quaternion.identity, grapgicParent.transform);

            timerValue = timerByTime.Evaluate(timeSinceEnabled);
            timer = timerValue;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
