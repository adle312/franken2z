using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCon2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject InB;
    public GameObject hideInb;

    void Start()
    {
        InB.gameObject.SetActive(false);
        hideInb.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Insgame()
    {
        InB.gameObject.SetActive(true);
        hideInb.gameObject.SetActive(false);
    }
}
