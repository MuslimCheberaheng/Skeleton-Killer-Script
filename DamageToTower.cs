using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToTower : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "KnightBody")
        {
            HealthBarScriptTower.healthTower -= 100;
            print("collider");
        }
            
        else
           print(collider.tag);



    }
}
