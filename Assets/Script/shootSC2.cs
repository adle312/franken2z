using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSC2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]

    private Transform bulletDir;

    [SerializeField]

    private GameObject Shurikenz;

    private Vector2 directShuriken;

    private float shurikenangle;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directShuriken = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        shurikenangle = Mathf.Atan2(directShuriken.y, directShuriken.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, shurikenangle - 90f);

        if (Input.GetMouseButtonDown(0))
        {
            ShurikenThrow();
        }

    }

    private void ShurikenThrow()
    {
        GameObject throwS = Instantiate(Shurikenz, bulletDir.position, bulletDir.rotation);
        throwS.GetComponent<Rigidbody2D>().velocity = bulletDir.up * 10f;
    }

  
}
