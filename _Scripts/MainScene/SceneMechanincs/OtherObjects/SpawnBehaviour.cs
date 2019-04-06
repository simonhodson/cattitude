using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OtherObjects
{
    public class SpawnBehaviour : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] PosNegObjects;
        private Vector3 spawnLocation;
        private int posNegChoice;

        void Start()
        {
            StartCoroutine(Delay());
        }

        IEnumerator Delay()
        {
            yield return new WaitForSeconds(2f);
            StartCoroutine(Spawn());
        }

        IEnumerator Spawn()
        {
            SpawnLocGenerator();
            Instantiate(PosNegObjects[Random.Range(0,PosNegObjects.Length)], spawnLocation, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(3.0f, 12.0f));
        }
        
        void SpawnLocGenerator()
        {
            // Generate random start position for x value
            var xValue = Random.Range(-3.25f, 3.25f);
            //y Value fixed to y value of spawn object
            var yValue = -6.465f;
            spawnLocation = new Vector3(xValue, yValue, 0f);
        }

        public void TrigggerSpawn()
        {
            StartCoroutine(Spawn());
        }

    }

}
