using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemy2Sc : MonoBehaviour
{
    //public GameObject enemy2targetPlayer;
    //public Transform Player
    private Vector2 enemy2chase;
    public Transform PlayerCurrentPos;
    public float distanceenemy2chase;
    public float Enemy2Speed;

    private SpriteRenderer E2sprite;

    //public static float E2deadhp;
    //public static float E2MaxHp = 3;

    //public int enemy2HP;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerCurrentPos = enemy2targetPlayer.GetComponent<Transform>();
        this.E2sprite = this.GetComponent<SpriteRenderer>();

       // E2deadhp = E2MaxHp;
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, PlayerCurrentPos.position) < distanceenemy2chase)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerCurrentPos.position, Enemy2Speed * Time.deltaTime);
        }

    

        this.E2sprite.flipX = PlayerCurrentPos.transform.position.x > this.transform.position.x;

       

    }



}
