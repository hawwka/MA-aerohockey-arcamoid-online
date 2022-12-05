using TMPro;
using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    public string ScoreName = "Any team score ";
    public TMP_Text Text;
    public int Points;
    
    // [HCFunction(nameof(IncreasePoints))]
    // public HCFunction IncreasePointsSubscribe = new HCFunction();
    //
    // [ActionFunction]
    // public void IncreasePoints(EventParams p)
    // {
    //     print(Points);
    //     Points++;
    //     Text.text = $"{ScoreName} {Points}";
    // }

    public void ResetUI()
    {
        Text.text = $"{ScoreName} {0}";
    }

    public int GetScores()
    {
        return Points;
    }

    public void ResetScores()
    {
        Points = 0;
    }
}
