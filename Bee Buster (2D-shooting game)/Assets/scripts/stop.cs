 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stop : MonoBehaviour
{ public GameObject stopMenu ;
   public void pause_button()
   {    Time.timeScale = 0 ;
        


   }
   public void play_button()
   {
       Time.timeScale = 1 ;
   }  
   public void home_button()
   {
       SceneManager.LoadScene("menu");
   }  
}
