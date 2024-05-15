using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject Game0verUI;
    public float maxhelath2 ;
    public float minhelath ;
    public float healBar;
    

     // Start is called before the first frame update
     void Start()
    {
        maxhelath2 = healBar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Game0ver()
    {
        Game0verUI.SetActive(true);
    }
}
