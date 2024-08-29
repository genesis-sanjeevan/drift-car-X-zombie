using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Car_rotation : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CarNametext;
    public scoresave CarSelection;
    public Camera camera1;
    public scoresave scoresave;

    public GameObject red_car_panel;
    public GameObject white_car_panel;
    public GameObject lambo_car_panel;
    public GameObject tesla_car_panel;

    public GameObject WhiteBuyButton;
    public GameObject LamboBuyButton;
    public GameObject teslaBuyButton;

    


    private void Update()
    {
        
       
        
    }


    public void first_selection()
    {
        camera1.transform.position = new Vector3(-10, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "the red car";
        red_car_panel.SetActive(true);
        white_car_panel.SetActive(false);
        lambo_car_panel.SetActive(false);
        tesla_car_panel.SetActive(false);

    }

    public void second_selection()
    {
        camera1.transform.position = new Vector3(0, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "the fast car";
        white_car_panel.SetActive(true);
        red_car_panel.SetActive(false);
        lambo_car_panel.SetActive(false);
        tesla_car_panel.SetActive(false);
    }

    public void third_selection()
    {
        camera1.transform.position = new Vector3(10, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "lambar gambar";
        lambo_car_panel.SetActive(true);
        white_car_panel.SetActive(false);
        red_car_panel.SetActive(false);
        tesla_car_panel.SetActive(false);
    }

    public void  forth_selection()
    {
        camera1.transform.position = new Vector3(20, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "Coming Soon";
        
    }
    public void fifth_selection()
    {
        camera1.transform.position = new Vector3(30, 3, -16.6f);
        tesla_car_panel.SetActive(true);
        white_car_panel.SetActive(false);
        red_car_panel.SetActive(false);
        lambo_car_panel.SetActive(false);
    }


    public void RedLockIn()
    {

        CarSelection.setCar(Cars.Prometheus);                
    }
    public void WhiteLockIn()
    {

        CarSelection.setCar(Cars.KoenigseggJeskoAbsolute);
    }
    public void lamboLockIn()
    {
        CarSelection.setCar(Cars.LamborghiniSianFKP37);

    }
    public void TeslaLockIn()
    {
        CarSelection.setCar(Cars.TeslaTruck);

    }

    public void White_buy_button()
    {
        if(scoresave.Total_Score >= 500)
        {
            Destroy(WhiteBuyButton);
            scoresave.Total_Score -= 500;
            

        }
    }
    public void Lambo_buy_button()
    {
        if(scoresave.Total_Score >= 1200)
        {
            Destroy(LamboBuyButton);
            scoresave.Total_Score -= 1200;
            

        }
    }

    public void tesla_buy_button()
    {
        if (scoresave.Total_Score >= 12000)
        {
            Destroy(teslaBuyButton);
            scoresave.Total_Score -= 12000;


        }
    }





}
