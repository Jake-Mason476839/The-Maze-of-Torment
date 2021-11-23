using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            GameVariables.keyCount+=2;
            Destroy(gameObject);
        }
    }
}
