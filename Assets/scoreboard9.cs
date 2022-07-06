using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreboard9 : MonoBehaviour
{
    public Transform player;
    float a,b,c,d,e,scorevalue4=0,Highscore9;
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
        if(player.position.y>=-0.1f)
        {
            scorevalue4=d;
       
        }
        scoreshow.text= "Score: " + scorevalue4.ToString("0");
        
     if (scorevalue4 >= PlayerPrefs.GetFloat("Highscore9",0)){
     
    
     PlayerPrefs.SetFloat ("Highscore9", scorevalue4);
  
       score3.text = "Highscore: " + scorevalue4.ToString("0");
 
     }
     
    score3.text = "Highscore: "+  PlayerPrefs.GetFloat("Highscore9",0).ToString("0");
    
    }
}

        
