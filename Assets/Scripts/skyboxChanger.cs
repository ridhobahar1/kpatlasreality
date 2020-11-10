using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxChanger : MonoBehaviour
{

    public Material[] skyboxes;
    int skyboxCounter = 0;
    int currentSkyboxNumber = 0;
    
    public void changeSkyBox()
    {
        skyboxCounter++;
        if(skyboxCounter >= skyboxes.Length)
        {
            skyboxCounter = 0;
        }
        RenderSettings.skybox = skyboxes[skyboxCounter];
    }
}
