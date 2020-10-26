using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerRoad : MonoBehaviour
{
    public GameObject[] roadTile;
    public float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public int roundCount;
    public float decreaseTime;
    public float minTime = 0.65f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawn <= 0)
        {

            Instantiate(roadTile[0], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                timeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= decreaseTime;
        }
    }

}
