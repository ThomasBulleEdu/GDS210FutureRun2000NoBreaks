using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcollide : MonoBehaviour
{
    public GameObject speedo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)


    {
        if (col.gameObject.tag == "player")
        {
            speedo.GetComponent<speedTracking>().currentAccel = speedo.GetComponent<speedTracking>().currentAccel / 2;
            Destroy(this.gameObject);
        }
     
    
     } 




}
    



