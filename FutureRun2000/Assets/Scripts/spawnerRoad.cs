using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerRoad : MonoBehaviour
{
    public GameObject[] roadTile;
    public GameObject speedo;
    public float speed;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public int roundCount;
    public float decreaseTime;
    public float cutOffPoint;
    public float minTime = 0.65f;
    int rand;
    int randCount;


    // Start is called before the first frame update
    void Start()
    {
        decreaseTime = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedo.GetComponent<speedTracking>().currentAccel;
        cutOffPoint = 100f / speed;
        if (timeBtwSpawn <= cutOffPoint)
        {
            if (roundCount == 0) 
            { 
                int rand = Random.Range(0, 3);
                Instantiate(roadTile[rand], transform.position, Quaternion.identity);
                timeBtwSpawn = cutOffPoint * 15;
                if (startTimeBtwSpawn > minTime)
                {
                    timeBtwSpawn -= cutOffPoint;
                }
                int randCount = Random.Range(20, 40);
                roundCount = randCount;
            }
            else
            {
                int rand = Random.Range(3, 12);
                Instantiate(roadTile[rand], transform.position, Quaternion.identity);
                timeBtwSpawn = cutOffPoint * 15;
                if (startTimeBtwSpawn > minTime)
                {
                    timeBtwSpawn -= cutOffPoint;
                }
                roundCount--;
            }
        }
        else
        {
            timeBtwSpawn -= cutOffPoint;
        }
    }

}
