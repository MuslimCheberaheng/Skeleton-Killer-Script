using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScriptKnight : MonoBehaviour
{
    
    Image healthBar;
    float maxHealthKnight = 100;
    public static float healthKnight;
    //public Skeleton Script;

    

    void Start()
    {
        healthBar = GetComponent<Image>();
        healthKnight = maxHealthKnight;
        //Script = GetComponent<Skeleton>();

       
    }
    
  

    
    



    void Update()
    {
        healthBar.fillAmount = healthKnight / maxHealthKnight;
       
        //if (HealthBarScriptKnight.health == 0)
        //{
            
        //}
    }
}
