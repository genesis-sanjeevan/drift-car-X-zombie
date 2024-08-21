using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu(menuName = "Create new save")]

public class scoresave : ScriptableObject 
{
    

    [SerializeField] int current_level_score;
    [SerializeField] int total_Score;

    public int Current_level_score { get { return current_level_score; } set { current_level_score = value; } }
    public int Total_Score { get { return total_Score; } set { total_Score = value; } }

    public int score_Add()
    {
        total_Score += current_level_score;
        return(total_Score);
    }
    
}
