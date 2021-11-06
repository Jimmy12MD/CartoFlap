using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CF.Core
{
    public class ScoreCounter : MonoBehaviour
    {   
        int score = 0;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                score += 1;
            }
        }
    }
}
