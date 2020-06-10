using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScriptTower : MonoBehaviour
{
    
    Image healthBar;
    float maxHealthTower = 500;
    public static float healthTower;
    //public Skeleton Script;

    

    void Start()
    {
        healthBar = GetComponent<Image>();
        healthTower = maxHealthTower;
        //Script = GetComponent<Skeleton>();

       
    }
    
  

    
    



    void Update()
    {
        healthBar.fillAmount = healthTower / maxHealthTower;
       
        //if (HealthBarScriptKnight.health == 0)
        //{
            
        //}
    }
}
