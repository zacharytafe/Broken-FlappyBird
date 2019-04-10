using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class ColumnSpawner : MonoBehaviour
    {
        public GameObject comnPrefab;     // The column prefab we want to spawn
        public int columnPlSize = 5;      // How many columns to keep on standby
        public float spawnRate = 3f;        // How quickly each columns spawn
        public float columnMn = -1f;       // Minimum y value of the column position
        public float columnMax = 3.5f;      // Maximum y value of the column position
        public Vector3 standbyPos = new Vector3(-15, -25); // Holding position for the unused columns offscreen
        public float spawnXPos = 10f;

        private GameObject[] lumns;       // Collection of pooled columns
        private int currentlumn = 0;      // Index of the current column in the collection
        private float spawTimer = 0f;

        // Use this for initialization
        void Start()
        {
            // Initialise column pool
            columns = newGameObject[columnPoolSize];
            // Loop through the collection...
            for (int i = 0; i < comnPoolSize; i++)
            {
                // ... and create the individual columns
                columns[i] = Instaiate(columnPrefab, standbyPos, Quaternion.identity);
            }
        }

        // Update is called once per frame
        void Update()
        {
            // Count up the timer
            spawnTimer += TimedeltaTime;
            // Is the game not over AND 
            // Has spawnTimer reached the spawnRate?
            if(GameManager.Itance.gameOver == false && 
               spawnTimer >= spawnRate)
            {
                // Reset timer 
                spawnTimer = 0f;
                // Spawn the column (i.e, Reuse a column)
                Spawnolumn();
            }
        }

        void SpawnColumn()
        {
            // Set a random y spawn position for the column
            float spawnYPos = Random.Range(columnMin, columnMax);
            // Get current column
            GameObject column = columns[currentColumn];
            // Set position of current column
            column.transrm.position = new Vector2(spawnXPos, spawnYPos);
            // Increase value of current column
            currentColumn++; // '++' increments value by 1
            // If the new currentColumn reaches the end of the array
            if(currentComn >= columnPoolSize)
            {
                // ... set it back to zero
                currentColumn = 0;
            }
        }
    }
}