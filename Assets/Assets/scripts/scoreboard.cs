using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreboard : MonoBehaviour
{
    public Transform player;
    float a,b,c,d,e,scorevalue=0,highscore;
    public TextMeshProUGUI score;
    public TextMeshProUGUI scoreshow;
    public TextMeshProUGUI score1;
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
            scorevalue=d;
       
        }
        scoreshow.text= "Score: " + scorevalue.ToString("0");
        
     if (scorevalue >= PlayerPrefs.GetFloat("highscore",0)){
     
    
     PlayerPrefs.SetFloat ("highscore", scorevalue);
  
       score1.text = "highscore: " + scorevalue.ToString("0");
 
     }
     
    score1.text = "highscore: "+  PlayerPrefs.GetFloat("highscore",0).ToString("0");
    
    }
}
