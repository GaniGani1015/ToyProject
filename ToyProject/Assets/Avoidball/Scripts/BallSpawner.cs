using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassStudy
{
    public class BallSpawner : MonoBehaviour
    {

        public GameObject ballPrefab; // 공장에서 찍어내는 물건
        public Transform[] SpawnPosition;

        public float spawnTime = 1.5f;
        public float timeChecker = 0f;

        // Start is called before the first frame update
        void Start()
        {
            Spawner();
           
        }

        private void Spawner()
        {
            int RandomIndex = Random.Range(0, 5);
            Instantiate(ballPrefab, SpawnPosition[RandomIndex]);
        }

        // Update is called once per frame
        void Update()
        {
            timeChecker += Time.deltaTime;
            if (timeChecker >= spawnTime)
            {

                Spawner();
                timeChecker = 0f;

            }
        }
    }
}
