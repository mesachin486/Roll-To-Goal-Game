using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TextMeshProUGUI scoreus;
    public TextMeshProUGUI Highscore;
    public static int scoreval = 0, val =0;
    void Start()
    {
       // scoreus = GetComponent<TextMeshProUGUI>();
       // Highscore = GetComponent<TextMeshProUGUI>();
        Highscore.text = "HighScore:" + PlayerPrefs.GetInt("high").ToString();
        val =PlayerPrefs.GetInt("high");
        scoreval =0;
    }
    void FixedUpdate()
    {
        scoreus.text = "Score:" + scoreval;
        if(val<scoreval)
        {
            val = scoreval;
            PlayerPrefs.SetInt("high",val);
            Highscore.text = "HighScore:"  +  val.ToString();
        }
    }
    
}
