using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void play()
   {    SceneManager.LoadScene("GamePlay");
        
   }

    public void settings()
   {
    
       SceneManager.LoadScene("Settings");
   }

    public void highscore()
   {
        print("Highscore");
   }
    public void exit()
   {
        print("Exit");
        Application.Quit();
   }
}
