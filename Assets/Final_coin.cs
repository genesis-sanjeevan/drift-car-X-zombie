using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Final_coin : MonoBehaviour
{
    public scoresave scoresave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = scoresave.Current_level_score.ToString();
    }
}
