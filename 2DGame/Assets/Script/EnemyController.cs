using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed, timeToRevert;
    [SerializeField] private Animator anim;
    [SerializeField] SpriteRenderer sp;

    [SerializeField] private Rigidbody2D rg;

    private const float idle_state = 0;
    private const float walk_state = 1;
    private const float revert_state = 2;

    private float currentTimeToRevert, currentState;

    private void Start()
    {
        currentState = walk_state;
        currentTimeToRevert = 0;
        rg.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (currentTimeToRevert >= timeToRevert)
        {
            currentState = revert_state;
            currentTimeToRevert = 0;
        }
        switch(currentState)
        {
            case idle_state:
                currentTimeToRevert += Time.deltaTime;
                break;
            case walk_state:
                rg.velocity = Vector2.right * speed;
                break;
            case revert_state:
                sp.flipX = !sp.flipX;
                speed *= -1;
                currentState = walk_state;
                break;
        }
        anim.SetFloat("Velocity", rg.velocity.magnitude);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EnemyStopper"))
        {
            currentState = idle_state;

        }
    }
}
