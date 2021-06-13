using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/**
 *  This class is responsible for controlling the action when a button is clicked
 */
public class ButtonController : MonoBehaviour
{
    public Button[] buttonList;
    public string[] scenesToLoad;
    void Start()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            var button = buttonList[i];
            var scene = scenesToLoad[i];
            button.onClick.AddListener(() => OnButtonClicked(scene));
        }
    }

    private void OnButtonClicked(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}