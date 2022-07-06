using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class movement : MonoBehaviour
{
    
    public float forwardforce=0.0000001f;
    public float sideforce=500f;
    public float backwardforce=0.5f;
    public Rigidbody rb;  
    public TextMeshProUGUI removetext;
    public GameObject gameoverimage;
    public GameObject mainmenu;
    public GameObject pausebutton;
    public GameObject restartbutton;
    public GameObject particlesystem;
 
    private Touch touch;
    public GameObject completelevelUI;
    public AudioSource ingame;
    public int leveltounlock;
    
    
    void start()
    {
        ingame.GetComponent<AudioSource>();
    
    }
   
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="obstacle")
            {
             gameoverimage.SetActive(true);
            mainmenu.SetActive(false);
            pausebutton.SetActive(false);
            restartbutton.SetActive(false);
            removetext.enabled = false;
           
           // this.transform.tag="death";
            ingame.Pause();
               // Debug.log("We hit");
               
              rb.constraints = RigidbodyConstraints.FreezeAll;
            }
    }
    void OnTriggerEnter()
    {
        completelevelUI.SetActive(true);
           mainmenu.SetActive(false);
            pausebutton.SetActive(false);
            restartbutton.SetActive(false);
            removetext.enabled = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            PlayerPrefs.SetInt("levelAt",leveltounlock);
             particlesystem.SetActive(true);
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
        rb.AddForce(0,0,forwardforce*Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
        rb.AddForce(sideforce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
        rb.AddForce(-sideforce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("s"))
        {
        rb.AddForce(0,0,-backwardforce*Time.deltaTime);
        }
        if(rb.position.y<-1f)
        {
           
            gameoverimage.SetActive(true);
            mainmenu.SetActive(false);
            pausebutton.SetActive(false);
            restartbutton.SetActive(false);
            removetext.enabled = false;
           // this.transform.tag="death";
            ingame.Pause();
        }
      //  if(Input.touchCount>0)
        // {
          //   touch=Input.GetTouch(0);
            // if(touch.phase==TouchPhase.Moved)
            // {
            //     rb.AddForce(touch.deltaPosition.x*forwardforce*Time.deltaTime,
              //   transform.position.y,
               //  touch.deltaPosition.y*Time.deltaTime*forwardforce);
             // }
     //   }
       
    
    }
}
