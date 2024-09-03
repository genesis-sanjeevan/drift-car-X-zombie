using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManagement : MonoBehaviour
{
    public GameObject MainMenu_panel;
    public GameObject pause_panel;
    public scoresave score;

    public void menu_button(string name)
    {
        switch (name)
        {
            case "start":
                SceneManager.LoadScene(1);
                break;
            case "home":
                SceneManager.LoadScene(0);
                break;
            case "garage":
                MainMenu_panel.SetActive(false);
                break;
            case "mainmenu":
                MainMenu_panel.SetActive(true);
                break;
            case "restart":
                SceneManager.LoadScene(1);
                break;
            case "exit":
                Application.Quit();
                break;
            case "pause":
                pause_panel.SetActive(true);
                Time.timeScale = 0.0f;
                break;
            case "resume":
                Time.timeScale = 1.0f;
                pause_panel.SetActive(false);
                break;
        }
    }
}
