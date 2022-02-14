using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject camFollowPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camFollowPlayer.transform.position.x, camFollowPlayer.transform.position.y, camFollowPlayer.transform.position.z - 10);
    }
}
