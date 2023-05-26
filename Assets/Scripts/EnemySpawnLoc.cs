using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLoc : MonoBehaviour
{
    public GameObject EnemyArmy;

    private float distanceX = 0;
    private float distanceY = 0;


    [SerializeField]
    private float spawnMultiplier;

    [SerializeField]
    private int frameCounter = 0;

    [SerializeField]
    private int spawnIncreaseCounter = 0;

    private const int FRAMESECONDS30 = 1500;
    private const int FRAMESECONDS20 = 1000;
    private const float ADDRANGEX = 6.5f;
    private const float ADDRANGEY = 4.5f;

    // Start is called before the first frame update
    void Start()
    {

        spawnMultiplier = 3; // Changes the Time in spawnrate

    }

    // Update is called once per frame
    public void Update()
    {
        float radians = Mathf.Deg2Rad * (int)Random.Range(1,360); //get radians

        //x and y distance for circle using sin and cos to always be on radius 
        distanceX = ((float)((Random.Range(0,1) * 2) + ADDRANGEX)) * Mathf.Cos(radians);

        distanceY = ((float)((Random.Range(0,1) * 2) + ADDRANGEY)) * Mathf.Sin(radians);
        
    }
    /*
    *   @int FRAMESECONDS
    *       Is Set to 1500 which is 30sec because unity fixed frame rate is 50fps
    *
    *   Counts the frames and then calls createEnemy to instatiate enemy     
    */
    public void FixedUpdate()
    {
        frameCounter++; //is used to convert seconds to frames
        spawnIncreaseCounter++;
        if(frameCounter * spawnMultiplier > FRAMESECONDS30)
        {
            frameCounter = 0;
            createEnemy();
        }

        if(spawnIncreaseCounter > FRAMESECONDS20)
        {
            spawnMultiplier += .1f;
            spawnIncreaseCounter = 0;
        }
    }

    // Instatiates enemy a public object named personpointer
    public void createEnemy()
    {
        GameObject instantiatedObject = Instantiate(EnemyArmy, transform.position + new Vector3(distanceX,distanceY,transform.position.z),Quaternion.identity);
    }
}
