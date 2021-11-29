using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CF.Core;

namespace CF.UI
{
    public class DeathScreenSwitcher : MonoBehaviour
    {
        [SerializeField] Canvas deathCanvas;

        Health health;

        // Start is called before the first frame update
        void Awake()
        {
            FindHealthStatus();
            SwitchDeathScreen();
        }

        // Update is called once per frame
        void Update()
        {
            SwitchDeathScreen();
        }

        private void SwitchDeathScreen()
        {
            deathCanvas.enabled = !health.IsAlive;
        }

        private void FindHealthStatus()
        {
            health = FindObjectOfType<Health>();

            if (health == null)
            {
                Debug.LogWarning("Health not found");
            }
        }
    }
}
