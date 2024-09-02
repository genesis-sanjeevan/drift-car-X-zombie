using System.Collections;
using System.Collections.Generic;
using Unity.Services.CloudSave;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManagement : MonoBehaviour
{
    public GameObject MainMenu_panel;
    public GameObject pause_panel;
    public scoresave score;

    public void Start_BUT()
    {
        SceneManager.LoadScene(1);
    }
    public void backToHome()
    {
        MainMenu_panel.SetActive(true);
    }
    public void garage()
    {
        MainMenu_panel.SetActive(false);
    }

    public void restart()
    {

        SceneManager.LoadScene(1);

    }

    public void Home()
    {
        SceneManager.LoadScene(0);
        
    }

    public void Exit()
    {
        Application.Quit();
    }


    public void Pause_panel_activate()
    {
        pause_panel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void Pause_panel_deactivate()
    {
        Time.timeScale = 1.0f;
        pause_panel.SetActive(false);
    }

}
