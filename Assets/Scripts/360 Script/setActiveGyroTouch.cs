using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveGyroTouch : MonoBehaviour
{ 
    
     public GameObject gyro;
    public bool activate;

    // Update is called once per frame
    void Update()
    {
        if(activate == true)
        {
            gyro.SetActive(true);
        }
        else
        {
            gyro.SetActive(false);
        }
    }
}
