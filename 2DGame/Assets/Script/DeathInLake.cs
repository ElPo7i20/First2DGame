using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathInLake : MonoBehaviour
{
    [SerializeField] GameObject robi;
    [SerializeField] GameObject losePanel;

    private float currentTime;
    private float maxTime = 5;

    private void Awake()
    {
        currentTime = maxTime;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Body")
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void Update()
    {
        if(currentTime <= 0)
        {
            robi.SetActive(false);
            losePanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            currentTime = maxTime;
        }
    }
}
