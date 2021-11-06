using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CF.Movement
{
    public class BirdRotation : MonoBehaviour
    {
        [SerializeField] float rotationVelocity = 2f;
        Rigidbody2D rg;


        const float MaxRotation = 20f;
        const float MinRotation = -90f;
        float currentRotation;

        // Start is called before the first frame update 
        void Awake()
        {
            rg = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            SetRotation();
        }

        private void SetRotation()
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, CalculateRotation());
        }


        //Adjusting the rotation of the bird depending on its speed
        private float CalculateRotation()
        {
            if (rg.velocity.normalized.y < 0)
            {
                currentRotation -= rotationVelocity * Time.deltaTime;

            }
            else if(rg.velocity.normalized.y >= 1)
            {
                currentRotation = MaxRotation;
            }
            currentRotation = Mathf.Clamp(currentRotation, MinRotation, MaxRotation);
            return currentRotation;
        }

        



    }
}
