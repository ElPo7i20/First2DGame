using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsCount : MonoBehaviour
{
    [SerializeField] private Text killsCounter;
    [SerializeField] private Text killsCounterLosePanel;
    [SerializeField] private Text killsCounterWinPanel;
    public int maxKillsCount;

    public void UpdateKillsCountText(int addKills)
    {
        maxKillsCount += addKills;
        killsCounter.text = maxKillsCount.ToString();
        killsCounterLosePanel.text = maxKillsCount.ToString();
        killsCounterWinPanel.text = maxKillsCount.ToString();
    }
}
