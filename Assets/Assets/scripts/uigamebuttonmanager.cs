using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uigamebuttonmanager : MonoBehaviour
{
    bool isPaused = false;
    // Start is called before the first frame update
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
     public void nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void pause()
    {
    
    if(isPaused)
    {
        Time.timeScale =1f;
        isPaused = false;

    }
    else
    
        {
           Time.timeScale =0f;
        isPaused = true; 
        }
    }
    
    public void quit()
    {
        SceneManager.LoadScene(2);
    }
    public void endgame()
    {
        Debug.Log("GAME OVER!");
    }
  
   

}