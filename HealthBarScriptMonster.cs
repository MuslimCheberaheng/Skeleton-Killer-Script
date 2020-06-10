using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScriptMonster : MonoBehaviour
{

    Image healthBar;
    float maxHealthMonster = 100;
    public static float healthMonster;
    //public Skeleton ActiveDead;
    public GameObject Skeleton;



    void Start()
    {
        healthBar = GetComponent<Image>();
        healthMonster = maxHealthMonster;
        //ActiveDead = GetComponent<Skeleton>();


    }



    void Update()
    {
        healthBar.fillAmount = healthMonster / maxHealthMonster;
    }


   // void Die()
   // {
    //    if (healthMonster == 0)
    //    {
    //        Die();
    //        print("225");
     //   }

}


   // void ReduceHealth()
    //{
    //    if (healthMonster == 0f)
     //   {
     //       Skeleton.GetComponent<Animator>().SetBool("isDead", true);
     //   }
   // }

    

