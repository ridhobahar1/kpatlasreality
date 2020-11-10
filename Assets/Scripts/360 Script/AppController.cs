using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    //public Animator fadingAnimator;
   // public Animator showMenuAnimator;
   // public GameObject imageGyro;
   // public GameObject imageTouch;
   // public Text textGyroOrTouch;
   /// public GameObject optionUp;
  /// public GameObject cameraPlayer;
   // public GameObject[] rooms;

    /*void Start()
    {
       if (rooms.Length!=0)
       {
            foreach(var room in rooms)
            {
                room.SetActive(false);
            }
            rooms[0].SetActive(true);
        }
    }
    
    public void GoToOtherRoom(GameObject activeRoom)
     {

        IEnumerator NextRoom(GameObject room)
        {
            yield return new WaitForSeconds(.5f);
            foreach (var otherRoom in rooms)
            {
                otherRoom.SetActive(false);
            }
            room.SetActive(true);
            Camera.main.transform.position = room.transform.position;
        }

         
     }*/
    //public void ChangeSkyBox(Material roomSkyBox)
    //{
    //    gameObject.GetComponent<AudioSource>().Play();
    //    
    //}
    public void ChangeSkyBox(Material matSkybox)
    {
        RenderSettings.skybox = matSkybox;
    }

  

}
