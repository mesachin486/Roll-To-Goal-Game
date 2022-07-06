﻿ using UnityEngine;
 using System.Collections;
 
 public class movingcode : MonoBehaviour 
 {
     // Using same speed reference in both, desktop and other devices
     public float speed1 =700;
     private float speed2 =500;
 
     void Main ()
         {
                 // Preventing mobile devices going in to sleep mode 
                 //(actual problem if only accelerometer input is used)
                 Screen.sleepTimeout = SleepTimeout.NeverSleep;
         }
 
     void Update()
         {
          
         if (SystemInfo.deviceType == DeviceType.Desktop) 
         {
             // Exit condition for Desktop devices
             if (Input.GetKey("escape"))
                 Application.Quit();
         }
         else
         {
             // Exit condition for mobile devices
             if (Input.GetKeyDown(KeyCode.Escape))
                 Application.Quit();            
         }
         
         
 
         }
     
     
     void FixedUpdate ()
         {
             if (SystemInfo.deviceType == DeviceType.Desktop) 
             { 
                     // Player movement in desktop devices
                 // Definition of force vector X and Y components
                 float moveHorizontal = Input.GetAxis("Horizontal");
                 float moveVertical = Input.GetAxis("Vertical");
                 // Building of force vector
                 Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);
                 // Adding force to rigidbody
                 GetComponent<Rigidbody>().AddForce(movement * speed1 * Time.deltaTime);
             }
             else
             {
                     // Player movement in mobile devices
                 // Building of force vector 
                 Vector3 movement = new Vector3 (Input.acceleration.x , 0.0f, (Input.acceleration.y + 0.7f)  );
                 // Adding force to rigidbody
                 GetComponent<Rigidbody>().AddForce(movement * speed2 * Time.deltaTime*2);
             }
 
 
         }
 
         
 }