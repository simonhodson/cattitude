using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OtherObjects
{
    public class CloadFloat : MonoBehaviour
    {
        private float floatSpeed = 1;

        // Use this for initialization
        void Start()
        {
            floatSpeed *= Time.deltaTime;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(Vector3.left * floatSpeed);

        }
    }
}
