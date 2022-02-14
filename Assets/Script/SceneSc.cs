using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSc : MonoBehaviour
{

    //public GameObject InsB;
    // Start is called before the first frame update
    void Start()
    {
        //InsB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayB()
    {
        SceneManager.LoadScene("FinalGamePlay");
    }


    public void Restart()
    {
        SceneManager.LoadScene("FinalGamePlay");
       //layerScript.dcount = 0;
    }

    public void Winning()
    {
        SceneManager.LoadScene("Intro");
    }
    public void WintoPlayagain()
    {
        SceneManager.LoadScene("FinalGamePlay");
        
    }
}
