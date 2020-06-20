using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToSkeleton : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy") //Attacking to the Enemies(Skeleton)
        {
            HealthBarScriptMonster.healthMonster -= 25; //deceased the enemies life point
            print(collider);
        }                  
    }
}
