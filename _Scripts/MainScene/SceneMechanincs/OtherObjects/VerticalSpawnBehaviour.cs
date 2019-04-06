using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace OtherObjects
{
    public class VerticalSpawnBehaviour : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] fluffyClouds;
        private Vector2 vSpawnLoc;
        private int cloudChoice;
        private float timeStep;

        void Start()
        {
            timeStep = 5.0f;
        }

        void Update()
        {
            if (Time.time > timeStep)
            {
                StartCoroutine(Vspwan());
                timeStep += 8.0f;
                Debug.Log(timeStep);
            }
        }

        IEnumerator Vspwan()
        {
            VspawnLocGenerator();
            if (vSpawnLoc != null)
            {
                Instantiate(fluffyClouds[Random.Range(0, fluffyClouds.Length)], vSpawnLoc, Quaternion.identity);
                yield return new WaitForSeconds(1f);
            }
        }

        void VspawnLocGenerator()
        {
            float xValue = 5.0f;
            float yValue = Random.Range(-0.1f, 4.9f);
            vSpawnLoc = new Vector2(xValue, yValue);
        }

    }
}
