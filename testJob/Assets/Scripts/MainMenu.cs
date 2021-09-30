using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   // private Image myImage;

   public void PlayGame()
   {
     //  myImage = GetComponent<Image>();
       StartCoroutine (delay());  
       StopCoroutine (delay());  
   }

   public void SettingsOn()
   {
       Debug.Log("Settings' on");
      //  myImage.enable=0;
   }

public void ExitGame()
{
    Debug.Log("Game's Over");

    Application.Quit();

}
  IEnumerator delay ()
  {
      yield return new WaitForSeconds (.5f);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
  }
}
