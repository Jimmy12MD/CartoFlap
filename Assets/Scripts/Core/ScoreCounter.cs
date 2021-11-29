using UnityEngine;

namespace CF.Core
{
    public class ScoreCounter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                Score += 1;
            }
        }

        public int Score { get; set; } = 0;

    }
}
