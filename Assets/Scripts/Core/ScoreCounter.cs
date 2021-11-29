using UnityEngine;
using CF.UI;

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

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

    }
}
