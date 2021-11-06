using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CF.Movement;

namespace CF.Core
{
    public class Portal : MonoBehaviour
    {

        [SerializeField] Transform outPortal;



        private void TeleportObstacle(ObstacleMove obstacle)
        {
            obstacle.transform.position = outPortal.transform.position;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {

            TeleportObstacle(collision.GetComponent<ObstacleMove>());
            
        }
    }
}
