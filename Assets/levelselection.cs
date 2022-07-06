using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* SUBSCRIBING TO MY YOUTUBE CHANNEL: 'VIN CODES' WILL HELP WITH MORE VIDEOS AND CODE SHARING IN THE FUTURE :) THANK YOU */

public class levelselection : MonoBehaviour
{
    public Button[] lvlButtons;
    public int levelnumber=3;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", levelnumber); /* < Change this int value to whatever your
                                                             level selection build index is on your
                                                             build settings */

        for (int i = 0; i < lvlButtons.Length; i++)
        {
           if (i + 3 > levelAt)
           {
                lvlButtons[i].interactable = false;
            }
        }
        
    }
    public void leveltoload(int level)
    {
          SceneManager.LoadScene (level);
    }

}
