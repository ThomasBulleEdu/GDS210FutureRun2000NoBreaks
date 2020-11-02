using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadDestroyer : MonoBehaviour
{

       void OnTriggerEnter(Collider col)
    {
        {
            Destroy(col.gameObject);
        }
    }
}
