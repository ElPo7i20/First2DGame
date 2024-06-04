using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Robot
{ 
 public class CutScene : MonoBehaviour
{
    [SerializeField] private GameObject firstCam;
    [SerializeField] private GameObject secondCam;
    [SerializeField] private PlayerInput move;
    [SerializeField] private float maxTime;

    private float currentTime;
    private void Start()
    {
        currentTime = 0;
        firstCam.SetActive(false);
        secondCam.SetActive(true);
        move.enabled = false;
    }
    private void Update()
    {
        if (currentTime <= maxTime)
        {
            currentTime += Time.deltaTime;
        }
        if (currentTime >= 5)
        {
            secondCam.SetActive(false);
            firstCam.SetActive(true);
        }
        if(currentTime >= maxTime)
        {
                move.enabled = true;
        }
    } 
 }
}
