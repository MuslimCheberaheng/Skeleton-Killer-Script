using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
  void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "KnightBody")
        { 
           HealthBarScriptKnight.healthKnight -= 10;        
                   
            print("666");
        }

        //else
           // print(collider.tag);

    }
}
