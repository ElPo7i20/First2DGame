using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Damageable"))
        {
            collision.collider.GetComponent<Health>().TakeDamage(damage);
            anim.SetBool("Damage", true);
        }
    }
}
