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
    private void Update()
    {
        
    }


    public void first_selection()
    {
        camera1.transform.position = new Vector3(-10, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "the red car";
        CarSelection.setCar(Cars.Prometheus);                

    }

    public void second_selection()
    {
        camera1.transform.position = new Vector3(0, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "the fast car";
        CarSelection.setCar(Cars.KoenigseggJeskoAbsolute);                
    }

    public void third_selection()
    {
        camera1.transform.position = new Vector3(10, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "lambo gambar";
        CarSelection.setCar(Cars.LamborghiniSianFKP37);                
    }

    public void  forth_selection()
    {
        camera1.transform.position = new Vector3(20, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "again the red car";
    }
    public void fifth_selection()
    {
        camera1.transform.position = new Vector3(30, 3, -16.6f);
        CarNametext.GetComponent<TextMeshProUGUI>().text = "the trash";
    }





}
