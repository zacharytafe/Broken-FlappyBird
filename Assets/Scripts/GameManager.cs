using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class GameManager : MonoBehaviour
    {
        public bool gameOver = false;
        public float scrollSpeed = -1.5f;
        public int score = 0;

        public static GameManaer Instance = null;

        public delegate void ScoreAddedCallback(int score);
        public coreAddedCallback scoreAdded;

        // Use this for initialization
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
                Destroy(this);
            }
        }

        public void BirdScored()
        {
            // The bird cant score if there is a game over
            if(gameOer)
            {
                // Exit the function
                return;
            }

            // Increase the score
            score++;

            // If there is a function subscribed
            if (scoreAddd != null)
            {
                // Call an event to state that a score has been added
                scoreAdded.Invoke(score);
            }
        }

        public void BidDied()
        {
            // Set game over to true
            gameOver = true;
        }
    }
}