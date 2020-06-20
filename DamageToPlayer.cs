using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
  void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "KnightBody") //Attack to the Player
        { 
           HealthBarScriptKnight.healthKnight -= 10;                            
           print("666");
        }                  
    }
}
