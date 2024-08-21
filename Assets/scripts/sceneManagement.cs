using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManagement : MonoBehaviour
{
    public Animation ani;
    
    public void Start_BUT()
    {
        SceneManager.LoadScene(1);
    }

    public void garage()
    {
        
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
