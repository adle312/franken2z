using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySc : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public GameObject thePlayer;
    public float distanceEnemy;
    public float enemySpeed;
    public Transform PlayerCurrentPosition; 

    private Vector2 targetThePlayer;

    public static int enemy1HP = 7;
    public SpriteRenderer Enemy1Sprite;


    void Start()
    {
        //targetThePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //PlayerCurrentPosition = thePlayer.GetComponent<Transform>();
        targetThePlayer = GetComponent<Transform>().position;

        this.Enemy1Sprite = this.GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, targetThePlayer.position, EnemySpeedz * Time.deltaTime);

        if (Vector2.Distance(transform.position, PlayerCurrentPosition.position) < distanceEnemy)
        {
            transform.position = Vector2.MoveTowards(transform.position, PlayerCurrentPosition.position, enemySpeed * Time.deltaTime);
            //Enemy1Sprite.flipX = false;

        }
        else
        {
            if (Vector2.Distance(transform.position, targetThePlayer) <= 0)
            {
                //Enemy1Sprite.flipX = false;
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, targetThePlayer, enemySpeed * Time.deltaTime);
                //Enemy1Sprite.flipX = true;
            }
        }

        if (enemy1HP <= 0)
        {
            gameObject.SetActive(false);
        }

        this.Enemy1Sprite.flipX = PlayerCurrentPosition.transform.position.x > Enemy1Sprite.transform.position.x;








    }
}
