using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class score_GetOldText : MonoBehaviour
{
    public scoresave saved_score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int txt =int.Parse(gameObject.GetComponent<TextMeshProUGUI>().text);
    }
}
