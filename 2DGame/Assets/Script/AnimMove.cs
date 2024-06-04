using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMove : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private Rigidbody2D rg;
    private void Awake()
    {
        anim.GetComponent<Animator>();
        rg.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        anim.SetFloat("Velocity", rg.velocity.magnitude);
    }
}
