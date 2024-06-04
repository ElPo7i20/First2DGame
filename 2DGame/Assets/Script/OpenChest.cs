using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    [SerializeField] GameObject chests;

    [SerializeField] private  Animator anim;

    [SerializeField] private GameObject openBttn;
    [SerializeField] private GameObject trgg;

    [SerializeField] private ParticleSystem getPoint;

    public int pointsCount;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            openBttn.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                trgg.SetActive(false);
                anim.SetBool("Open", true);
                getPoint.Play(true);
                openBttn.SetActive(false);
                pointsCount += 1;
                chests.GetComponent<AddPoints>().UpdateText(pointsCount);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Body")
        {
            openBttn.SetActive(false);
        }
    }
}
