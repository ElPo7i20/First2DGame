using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Robot
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer robi;
        private Shooter shooter;
        private PlayerMovement playerMove;
        private void Awake()
        {
            robi = robi.GetComponent<SpriteRenderer>();
            shooter = GetComponent<Shooter>();
            playerMove = GetComponent<PlayerMovement>();
        }
        private void Update()
        {
            float horizont = Input.GetAxis(GlobalStringVar.horizontal);
            bool jump = Input.GetKeyDown(KeyCode.UpArrow);

            if(Input.GetKey(KeyCode.LeftArrow))
            {
                robi.flipX = true;
            }

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                robi.flipX = false;
            }

            if (Input.GetButtonDown(GlobalStringVar.fire))
            {
                shooter.Shoot(horizont);
            }
            playerMove.Move(horizont, jump);
        }
    }
}