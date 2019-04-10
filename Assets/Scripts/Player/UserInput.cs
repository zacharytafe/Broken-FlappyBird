using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    [RequireComponent(typeof(Bird))]
    public class UserInput : MonoBehaviour
    {
        private Birdbird;

        // Use this for initialization
        void Start()
        {
            bird = GetCompo  nent<Bird>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check for mouse down
            if (Input.GetM  ouseButtonDown(0))
            {
                // Flap the bird
                bird.Flap();
            }
        }
    }
}