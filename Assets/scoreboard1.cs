using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreboard1 : MonoBehaviour
{
    public Transform player;
    float a,b,c,d,e,scorevalue1=0,Highscore;
    public TextMeshProUGUI score;
    public TextMeshProUGUI scoreshow;
    public TextMeshProUGUI score2;
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
            scorevalue1=d;
       
        }
        scoreshow.text= "Score: " + scorevalue1.ToString("0");
        
     if (scorevalue1 >= PlayerPrefs.GetFloat("Highscore",0)){
     
    
     PlayerPrefs.SetFloat ("Highscore", scorevalue1);
  
       score2.text = "Highscore: " + scorevalue1.ToString("0");
 
     }
     
    score2.text = "Highscore: "+  PlayerPrefs.GetFloat("Highscore",0).ToString("0");
    
    }
}
