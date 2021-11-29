using UnityEngine;
using UnityEngine.UI;
using CF.Core;

namespace CF.UI
{
    public class UpdateScore : MonoBehaviour
    {
        [SerializeField] Text scoreText;

        ScoreCounter scoreCounter;

        private void Awake()
        {
            FindScoreCounter();
        }

        private void Update()
        {
            UpdateText(scoreCounter.Score);
        }

        private void FindScoreCounter()
        {
            scoreCounter = FindObjectOfType<ScoreCounter>();
            if (scoreCounter == null)
            {
                Debug.LogWarning("ScoreCounter not found");
            }
        }

        public void UpdateText(int score)
        {
            scoreText.text = score.ToString();
        }
    }

}