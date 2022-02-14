using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D traprb;

    void Start()
    {
        traprb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "playergame")
        {
            traprb.isKinematic = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "playergame")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.name == "land")
        {
            Destroy(this.gameObject);
        }
    }
}
