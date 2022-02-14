using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGo : MonoBehaviour
{
    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D breakObj)
    {
        if (breakObj.gameObject.tag == "thewall")
        {
            Destroy(this.gameObject);
        }

        if (breakObj.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
            Destroy(breakObj.gameObject);
            //EnemySc.enemy1HP -= 1;
        }
        if (breakObj.gameObject.tag == "GameLand")
        {
            Destroy(this.gameObject);
        }
        if (breakObj.gameObject.tag == "enemy2")
        {
            Destroy(this.gameObject);
            Destroy(breakObj.gameObject);
            //breakObj.HitByPlayer
            //TheEnemy2Sc.enemy2HP -= 1;
            //TheEnemy2Sc.
            //TheEnemy2Sc.E2deadhp -= 1;
        
    
        }

 
        //Destroy(gameObject);



        if (breakObj.gameObject.tag == "thewall")
        {
            Destroy(this.gameObject);
            Destroy(breakObj.gameObject);
            //WallScz.healthWall -= 1; 
        }


    }



}
