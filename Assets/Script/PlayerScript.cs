using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float playerSp = 8f;
    public float JumpSp;

    public bool JumpCheck = false;
    //public static int jumpNum = 0;

    bool FaceTurnRight = true;

    public SpriteRenderer playerSprite;

  //public static int dcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerMove = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += playerMove * Time.deltaTime * playerSp;

        if (Input.GetButtonDown("Jump") && JumpCheck == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 11f), ForceMode2D.Impulse);
           //jumpNum = jumpNum + 1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerSprite.flipX = true;
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            playerSprite.flipX = false;
        }



   

    }




    private void OnCollisionEnter2D(Collision2D collectStone)
    {
        if (collectStone.gameObject.tag == "medal")
        {
            Destroy(collectStone.gameObject);
        }
        if (collectStone.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("Restart");
        //  ResetdCount();

        }
        if (collectStone.gameObject.tag == "enemy2")
        {
            SceneManager.LoadScene("Restart");
         // ResetdCount();
        }
        if (collectStone.gameObject.tag == "trapz")
        {
            SceneManager.LoadScene("Restart");
        //  ResetdCount();

        }
        if (collectStone.gameObject.tag == "diamond")
        {
            Destroy(collectStone.gameObject);
          //dcount = dcount + 1;
            
        }
        if (collectStone.gameObject.name == "SecDoor")
        {
            SceneManager.LoadScene("Winning");
        }
        
    }




   





}
