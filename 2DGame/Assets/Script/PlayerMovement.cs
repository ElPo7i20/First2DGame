using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private Transform groundCollider;
    private bool isGrounded = false;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffset;
    [SerializeField] private LayerMask groundMask;

    private void FixedUpdate()
    {
        Vector3 overlap = groundCollider.position;
        isGrounded = Physics2D.OverlapCircle(overlap, jumpOffset, groundMask);
    }
    public void Move(float direction, bool jump)
    {
        if(jump)
        {
            Jump();
        }
        if (Mathf.Abs(direction) > 0)
        {
            HorizontMove(direction);
        }
    }
    private void HorizontMove(float direction)
    {
        rb.velocity = new Vector2(curve.Evaluate(direction), rb.velocity.y);
    }
    private void Jump()
    {
        if (isGrounded == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
