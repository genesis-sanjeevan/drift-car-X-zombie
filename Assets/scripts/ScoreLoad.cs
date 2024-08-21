
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class ScoreLoad : MonoBehaviour
{
    public scoresave saved_score;

    private void Start()
    {
        saved_score.score_Add();
        gameObject.GetComponent<TextMeshProUGUI>().text = saved_score.Total_Score.ToString();
    }




}
