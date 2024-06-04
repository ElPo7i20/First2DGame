using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimDamage : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public void EndAnim()
    {
        anim.SetTrigger("Damage");
    }
    public void EndRobiAnim()
    {
        anim.SetBool("Damage", false);
    }
}
