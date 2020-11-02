using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public float speed;
    public GameObject speedo;
    public float rotateDegrees;
    public float timeAlive;

    // Start is called before the first frame update
    void Start()
    {
        speedo = GameObject.FindWithTag("Speedometer");
        transform.Rotate(rotateDegrees, 0, 0);
        timeAlive = 0;
    }

    // Update is called once per frame
    void Update()
    {
        speed = speedo.GetComponent<speedTracking>().currentAccel;
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
