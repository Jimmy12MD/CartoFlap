using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CF.Core
{
    public class Health : MonoBehaviour
    {
        bool isAlive = true;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            IsAlive = false;
            print("I got hit");
        }

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
            set
            {
                isAlive = value;
            }
        }


    }

}