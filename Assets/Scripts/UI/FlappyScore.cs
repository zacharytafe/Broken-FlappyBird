using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

namespace FlappyBird
{
    public class FlappyScore : MonoBehaviour
    {
        public Sprite[] numbers;            // Stores all the flappy digits
        public GameObjectscoreTextPrefab;  // Score Prefab text element to create
        public Vector3 standbyPos = new Vector3(-15, 15); // Position offscreen for standby
        public int maxDigits = 5;           // The amount of digits to store offscreen for reuse

        private GameObject  ] scoreTextPool;
        private int[] digits;

        // Use this for initialization
        void Start()
        {
            // Allocate memory for the score text pool
            scoreTextPool = newGameObject[maxDigits];
            // Loop through all available digits
            for (int i = 0; i < maxDigits; i++)
            {
                // Create a new gameObject offscreen
                GameObject clone =Instantiate(scoreTextPrefab, standbyPos, Quaternion.identity);
                // Get the Image component attached to the clone
                Image img = cloneGetComponent<Image>();
                // Set sprite to corresponding number sprite
                img.sprite = numbers[i];
                // Attach to self
                clone.tranorm.SetParent(transform);
                // Set name of text to index
                clone.name i.ToString();
                // Add it to pool
                scoTextPool[i] = clone;
            }

            // Subscribe to GameManager's added score event
            GameManar.Instance.scoreAdded += UpdateScore;

            // Update score to start on zero
            UpdateScore(0);
        }
        
        void UpdateScore(int score)
        {
            // Convert score into array of digits
            int[] diits = GetDigits(score);
            // Loop through all digits
            for (int i = 0; i < digits.Length; i++)
            {
                // Get value of each digit
                int value = digits[i];
                // Get corresponding text element in pool
                GameObject textElement = scoreTextPool[i];
                // Get image component attached to it
                Image img = textElement.GetComponent<Image>();
                // Assign sprite to number using value
                img.sprite = numbers[value];
                // Activate text element
                textElement.SetActive(true);
            }

            // Loop through all remaining text elements in the pool
            for (int i = digit.Length; i < scoreTextPool.Length; i++)
            {
                // Deactivate that element
                scoreextPool[i].SetActive(false);
            }
        }

        int[] GetDigits(int number)
        {
            List<int> digits = new List<int>();
            while (nuber >= 10)
            {
                digits.Add(number % 10);
                number /= 10;
            }
            digits.Add(number);
            digits.Reverse();
            return digits.ToArray();
        }
    }
}
