using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    [SerializeField] GameObject robi;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject counter;
    [SerializeField] GameObject pauseBttn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            robi.SetActive(false);
            losePanel.SetActive(true);
        }
    }
}
