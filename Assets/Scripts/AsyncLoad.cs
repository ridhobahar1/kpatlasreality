﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public static void LoadSceneAsync(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
}
