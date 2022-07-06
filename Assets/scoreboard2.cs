using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreboard2 : MonoBehaviour
{
    public Transform player;
    float a,b,c,d,e,scorevalue3=0,Highscore3;
    public TextMeshProUGUI score;
    public TextMeshProUGUI scoreshow;
    public TextMeshProUGUI score3;
    public Vector3 offset;
    void start()
    {
     
    }
    void Update()
    {
        a = player.position.z ;
        b = player.position.x;
        c =offset.x;
        e =offset.z;
        d=a+e;
        score.text = d.ToString("0");
        if(player.position.y>=-0.8f)
        {
            scorevalue3=d;
       
        }
        scoreshow.text= "Score: " + scorevalue3.ToString("0");
        
     if (scorevalue3 >= PlayerPrefs.GetFloat("Highscore3",0)){
     
    
     PlayerPrefs.SetFloat ("Highscore3", scorevalue3);
  
       score3.text = "Highscore: " + scorevalue3.ToString("0");
 
     }
     
    score3.text = "Highscore: "+  PlayerPrefs.GetFloat("Highscore3",0).ToString("0");
    
    }
}

        
