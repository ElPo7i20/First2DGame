using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Damageable"))
        {
            collision.GetComponent<GoblinHealth>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
