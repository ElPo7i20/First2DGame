using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBack : MonoBehaviour
{
    [SerializeField] GameObject firstCam;
    [SerializeField] GameObject secondCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Body")
        {
            firstCam.SetActive(false);
            secondCam.SetActive(true);
        }
    }
}

