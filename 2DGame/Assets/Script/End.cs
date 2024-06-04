using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    [SerializeField] private GameObject endPanel;
    [SerializeField] private GameObject robi;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            endPanel.SetActive(true);
            robi.SetActive(false);
            Debug.Log("Fuck");
        }
    }
}
