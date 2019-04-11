﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    [RequireComponent(typeof(Bird))]
    public class UserInput : MonoBehaviour
    {
        private float Bird;

        // Use this for initialization
        void Start()
        {
            Bird = GetComponent<Bird>();
        }

        // Update is called once per frame
        void Update()
        {
            // Check for mouse down
            if (Input.GetMouseButtonDown(0))
            {
                // Flap the bird
                Bird.Flap();
            }
        }
    }
}