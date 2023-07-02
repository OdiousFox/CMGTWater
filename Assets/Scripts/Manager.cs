using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    private int iScore = 0;

    public void IncreaseScore(int amount  = 1) {
        iScore += amount;
        score.text = iScore.ToString();
    }    
}
