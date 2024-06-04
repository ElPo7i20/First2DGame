using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePoint;
    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(bullet, firePoint.position, Quaternion.identity);
        Rigidbody2D bulletVelocity = currentBullet.GetComponent<Rigidbody2D>();
        if(direction >= 0)
        {
            bulletVelocity.velocity = new Vector2( 1 * fireSpeed, bulletVelocity.velocity.y);

        }
        else
        {
            bulletVelocity.velocity = new Vector2( -1 * fireSpeed, bulletVelocity.velocity.y);
        }
    }
}
