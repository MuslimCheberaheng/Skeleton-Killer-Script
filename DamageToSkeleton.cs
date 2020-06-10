using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToSkeleton : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Enemy")
        {
            HealthBarScriptMonster.healthMonster -= 25;
            print(collider);
        }
            
       // else
           // print(collider.tag);



    }
}
