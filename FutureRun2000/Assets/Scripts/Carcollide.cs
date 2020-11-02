using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcollide : MonoBehaviour
{
    public GameObject speedo;

    // Start is called before the first frame update
    void Start()
    {
        speedo = GameObject.FindWithTag("Speedometer");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            speedo.GetComponent<speedTracking>().currentAccel = speedo.GetComponent<speedTracking>().currentAccel / 2;
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("UhOH" + col.gameObject.tag);
        }

     } 
}
    



