using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    [SerializeField] private Text poinstTextWinPanel;
    [SerializeField] private Text pointsTextLosePanel;

    public int maxPoints;

    public void UpdateText(int pointsCount)
    {
        maxPoints += pointsCount;
        pointsText.text = maxPoints.ToString();
        poinstTextWinPanel.text = maxPoints.ToString();
        pointsTextLosePanel.text = maxPoints.ToString();
    }
}
