using UnityEngine;
using UnityEngine.UI;

namespace CF.UI
{
    public class UpdateScore : MonoBehaviour
    {
        [SerializeField] Text scoreText;
        


        public void UpdateText(int score)
        {
            scoreText.text = score.ToString();
        }
    }

}