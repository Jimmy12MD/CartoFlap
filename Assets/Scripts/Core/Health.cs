using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CF.Core
{
    public class Health : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            IsAlive = false;
            print("I got hit");
        }

        public bool IsAlive { get; set; } = true;


    }

}