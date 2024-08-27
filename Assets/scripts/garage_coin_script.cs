using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class garage_coin_script : MonoBehaviour
{
    public TextMeshProUGUI main_menu_coin_text;

    private void Start()
    {
        
        string txt = main_menu_coin_text.text;
        gameObject.GetComponent<TextMeshProUGUI>().text = txt;

    }
}
