using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Riding : MonoBehaviour
{
    [SerializeField] private HingeJoint2D firstWheel;
    [SerializeField] private HingeJoint2D secondWheel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Robi")
        {
            firstWheel.useMotor = true;
            secondWheel.useMotor = true;
        }
    }
}
