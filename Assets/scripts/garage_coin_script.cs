using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class garage_coin_script : MonoBehaviour
{
    public TextMeshProUGUI main_menu_coin_text;
    public scoresave saved_score;

    private void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = saved_score.Total_Score.ToString();

    }
}
