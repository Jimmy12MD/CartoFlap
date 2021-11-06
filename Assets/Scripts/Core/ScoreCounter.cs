using UnityEngine;
using CF.UI;

namespace CF.Core
{
    public class ScoreCounter : MonoBehaviour
    {   
        int score = 0;

        UpdateScore updateScore;


        private void Awake()
        {
            FindUpdateScore();
            updateScore.UpdateText(score);
        }

        private void FindUpdateScore()
        {
            updateScore = FindObjectOfType<UpdateScore>();

            if (updateScore == null)
            {
                Debug.LogWarning("UpdateScore not found");
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                score += 1;
                updateScore.UpdateText(score);
            }
        }


    }
}
