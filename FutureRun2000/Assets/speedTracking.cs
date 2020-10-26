using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedTracking : MonoBehaviour
{
    public float currentAccel;


    // Start is called before the first frame update
    void Start()
    {
        currentAccel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentAccel += 0.01f;
    }
}
