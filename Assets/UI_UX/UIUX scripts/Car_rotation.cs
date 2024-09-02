
using TMPro;
using UnityEngine;

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

    private void Start()
    {
        if(!scoresave.Car_white_locked) { Destroy(WhiteBuyButton); }
        if(!scoresave.Car_lambo_locked) { Destroy(LamboBuyButton); }
        if(!scoresave.Car_tesla_locked) { Destroy(teslaBuyButton); }

    }

    public void SelectCar(int CarIndex)
    {
        string txt = CarNametext.GetComponent<TextMeshProUGUI>().text;

        switch (CarIndex)
        {
            case 0:
                camera1.transform.position = new Vector3(-10, 3, -16.6f);
                txt = "the red car";
                red_car_panel.SetActive(true);
                white_car_panel.SetActive(false);
                lambo_car_panel.SetActive(false);
                tesla_car_panel.SetActive(false);
            break;

            case 1:
                camera1.transform.position = new Vector3(0, 3, -16.6f);
                txt = "the fast car";
                white_car_panel.SetActive(true);
                red_car_panel.SetActive(false);
                lambo_car_panel.SetActive(false);
                tesla_car_panel.SetActive(false);
            break ;

            case 2:
                camera1.transform.position = new Vector3(10, 3, -16.6f);
                txt = "lambar gambar";
                lambo_car_panel.SetActive(true);
                white_car_panel.SetActive(false);
                red_car_panel.SetActive(false);
                tesla_car_panel.SetActive(false);
            break;

            case 3:
                camera1.transform.position = new Vector3(20, 3, -16.6f);
                txt = "Coming Soon";
            break;

            case 4:
                camera1.transform.position = new Vector3(30, 3, -16.6f);
                txt = "The Trash car";
                tesla_car_panel.SetActive(true);
                white_car_panel.SetActive(false);
                red_car_panel.SetActive(false);
                lambo_car_panel.SetActive(false);
            break;

            default:
                camera1.transform.position = new Vector3(20, 3, -16.6f);
                txt = "Coming Soon";
            break;

        }
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
            scoresave.Car_white_locked = false;
            Destroy(WhiteBuyButton);
            scoresave.Total_Score -= 500;
        }
    }
    public void Lambo_buy_button()
    {
        if(scoresave.Total_Score >= 1200)
        {
            scoresave.Car_lambo_locked = false;
            Destroy(LamboBuyButton);
            scoresave.Total_Score -= 1200;
        }
    }

    public void tesla_buy_button()
    {
        if (scoresave.Total_Score >= 12000)
        {
            scoresave.Car_tesla_locked = false;
            Destroy(teslaBuyButton);
            scoresave.Total_Score -= 12000;
        }
    }
}
