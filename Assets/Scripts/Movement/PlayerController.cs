using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CF.Movement
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float velocity = 5f;

        Rigidbody2D rg;

        // Start is called before the first frame update
        void Awake()
        {
            rg = GetComponent<Rigidbody2D>();
           
        }

        private void CalculateJumpForce()
        {
            Vector2 force = new Vector2(0f, velocity);
            rg.velocity = new Vector2(0f, 0f); //resets velocity for smooth jumping  
            rg.velocity += force;
        }


        //Used in Player Input
        public void Jump(InputAction.CallbackContext context)
        {
            //Prevents from double jump
            if (context.performed)
            {
                CalculateJumpForce();
            }     
        }
    }

}