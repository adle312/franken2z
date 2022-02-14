using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSc : MonoBehaviour
{
    public GameObject shurikenB;
    public Transform shurikenP;
    public float BulletSp = 10;
    

    Vector2 pointD;
    float pointAngle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointD = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //pointAngle = Mathf.Atan2(pointD.y, pointD.x) * Mathf.Rad2Deg;
        //shurikenP.rotation = Quaternion.Euler(0, 0, pointAngle);

        Vector2 moveVector = pointD - (Vector2)transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject shurikenClone = Instantiate(shurikenB);
            shurikenClone.transform.position = shurikenP.position;
            shurikenClone.transform.right = moveVector;
            //shurikenClone.transform.rotation = Quaternion.Euler(0, 0, pointAngle);

            //shurikenClone.GetComponent<Rigidbody2D>().velocity = shurikenP.right * BulletSp;
            shurikenClone.GetComponent<Rigidbody2D>().velocity = moveVector.normalized * BulletSp;
            //shurikenClone.transform.rotation = Quaternion.LookRotation(shurikenClone.GetComponent<Rigidbody2D>().velocity);
            
        }
    }
}
