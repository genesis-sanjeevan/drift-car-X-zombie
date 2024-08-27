using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManagement : MonoBehaviour
{
    public Animation ani;
    public GameObject MainMenu_panel;
    
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

}
