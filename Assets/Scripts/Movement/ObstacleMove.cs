using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CF.Movement
{
    public class ObstacleMove : MonoBehaviour
    {
        [SerializeField] float moveVelocity = 5f;

        // Update is called once per frame
        void Update()
        {
            MoveObstacle();
        }


        private void MoveObstacle()
        {
            transform.Translate(-transform.right * moveVelocity * Time.deltaTime);
        }
    }

}