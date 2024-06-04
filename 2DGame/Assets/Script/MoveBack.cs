using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    [SerializeField] private Transform back;
    [SerializeField] private Transform cam;
    private Vector3 offsetCam;
    private Vector3 offsetBack;
    private void Start()
    {
        offsetBack = back.position - cam.position;
    }
    private void Update()
    {
        back.position = cam.position + offsetBack;
    }
}
