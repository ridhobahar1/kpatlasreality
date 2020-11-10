using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoad : MonoBehaviour
{

    
    public void GoToAbout(){
        AsyncLoad.LoadScene("About");
  }
  public void ExitApplication(){
     Application.Quit();
  }
  public void GoToMainMenu(){
        AsyncLoad.LoadScene("MainMenu");
  }
  public void GoToMarker(){
        AsyncLoad.LoadScene("Marker");
  }

    public void GoToARScene()
    {
        AsyncLoad.LoadScene("ARScene");
    }

    public void GoToTipeScene()
    {
        AsyncLoad.LoadScene("TipeScene");
    }

    public void GoToTipe1A()
    {
        AsyncLoad.LoadScene("3601A");
    }

    public void GoToTipe2A()
    {
        AsyncLoad.LoadScene("3602A");
    }

    public void GoToLoading()
    {
        AsyncLoad.LoadScene("Loading");
    }

}