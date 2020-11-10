﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotate_house2 : MonoBehaviour
{

    public GameObject objectRotate2;

    public float rotateSpeed = 50f;
    bool rotateStatus = false;

    public void Rotasi()
    {
        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            objectRotate2.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }


}