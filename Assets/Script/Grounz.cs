using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounz : MonoBehaviour
{
    public GameObject Controlthejump;
    // Start is called before the first frame update
    void Start()
    {
        Controlthejump = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D jumpCol)
    {
        if (jumpCol.collider.tag == "GameLand")
        {
            Controlthejump.GetComponent<PlayerScript>().JumpCheck = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D jumpCz)
    {
        if (jumpCz.collider.tag == "GameLand")
        {
            Controlthejump.GetComponent<PlayerScript>().JumpCheck = false;
        }
    }


}
