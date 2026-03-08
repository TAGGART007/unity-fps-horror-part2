using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class animation : MonoBehaviour {
    
    public Animator player;
  
    public GameObject camera1;
    public GameObject camera2;
    public GameObject restart;
    public GameObject Win;
    public GameObject main;
    bool state = true;
    public Text score;
    public int count;
    public Text gameovers;

    float scorei;

    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update () {

        if (scorei == 6)
        {
            score.text = "you win";
            Win.SetActive(true);
            restart.SetActive(true);
            main.SetActive(true);
        }



        if (Input.GetKey(KeyCode.W))
        {
            player.SetInteger("State", 1);
        
        }
      else   if (Input.GetKeyDown(KeyCode.V))
        {
            state = !state;
            camera1.SetActive(state);
            camera2.SetActive(!state);
            
        }
        
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            player.SetInteger("State", 4);
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            player.SetInteger("State", 3);
        }
        else
        {
            player.SetInteger("State", 0);
        }
	}
   

   
}
